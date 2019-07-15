using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ctiencrypt
{
    public partial class Form1 : Form
    {
        BackgroundWorker bwEncrypt = new BackgroundWorker();
        BackgroundWorker bwDecrypt = new BackgroundWorker();

        string normalText = "";
        string encryptedText = "";

        bool success = true;
        string timeUsed = "";

        public Form1()
        {
            InitializeComponent();

            txtNormalText.MaxLength = int.MaxValue;
            txtEncryptedText.MaxLength = int.MaxValue;

            // Change UI Language here
            SetUILanguage();

            SetToolTip();

            // An universal font that can display all languages in the world
            LoadEmbededFont();

            bwEncrypt.DoWork += bwEncrypt_DoWork;
            bwEncrypt.RunWorkerCompleted += bwEncrypt_RunWorkerCompleted;

            bwDecrypt.DoWork += bwDecrypt_DoWork;
            bwDecrypt.RunWorkerCompleted += bwDecrypt_RunWorkerCompleted;
        }

        #region UI Language

        void SetUILanguage()
        {
            this.Text = Language.CTITextEncryption + " " + config.Version;
            lbPwd1.Text = Language.Pwd1;
            lbPwd2.Text = Language.Pwd2;
            lbPwd3.Text = Language.Pwd3;
            lbPwd4.Text = Language.Pwd4;

            btResetPwd.Text = Language.ButtonErasePwd;
            btResetAll.Text = Language.ButtonEraseAll;
            btInfo.Text = Language.ButtonInfo;

            btEncrypt.Text = Language.ButtonEncrypt;
            btNormalCopy.Text = Language.ButtonCopy;
            btNormalPaste.Text = Language.ButtonPaste;
            btResetNormal.Text = Language.ButtonErase;
            btFont.Text = Language.ButtonFont;

            btDecrypt.Text = Language.ButtonDecrypt;
            btDecryptCopy.Text = Language.ButtonCopy;
            btDecryptPaste.Text = Language.ButtonPaste;
            btResetDecrypt.Text = Language.ButtonErase;

            txtNormalText_TextChanged(this, null);
            txtEncryptedText_TextChanged(this, null);
        }

        void SetToolTip()
        {
            toolTip1.SetToolTip(btResetPwd, Language.TooltipResetPwd);
            toolTip1.SetToolTip(btResetAll, Language.TooltipResetAll);
            toolTip1.SetToolTip(btInfo, Language.TooltipInformation);

            toolTip1.SetToolTip(btEncrypt, Language.TooltipEncrypt);
            toolTip1.SetToolTip(btNormalCopy, Language.TooltipCopyTxtNormal);
            toolTip1.SetToolTip(btNormalPaste, Language.TooltipPasteTxtNormal);
            toolTip1.SetToolTip(btResetNormal, Language.TooltipResetTxtNormal);
            toolTip1.SetToolTip(btFont, Language.TooltipChangeFont);

            toolTip1.SetToolTip(btDecrypt, Language.TooltipDecrypt);
            toolTip1.SetToolTip(btDecryptCopy, Language.TooltipCopyTxtEncrypted);
            toolTip1.SetToolTip(btDecryptPaste, Language.TooltipPasteTxtEncrypted);
            toolTip1.SetToolTip(btResetDecrypt, Language.TooltipResetTxtEncrypted);
        }

        #endregion

        #region Font Settings

        void LoadEmbededFont()
        {
            if (config.FontSegoeUI.Families.Length == 0)
            {
                try
                {
                    unsafe
                    {
                        fixed (byte* pFontData = Properties.Resources.segoeui)
                        {
                            uint dummy = 0;
                            config.FontSegoeUI.AddMemoryFont((IntPtr)pFontData, Properties.Resources.segoeui.Length);
                            config.AddFontMemResourceEx((IntPtr)pFontData, (uint)Properties.Resources.segoeui.Length, IntPtr.Zero, ref dummy);
                        }
                    }
                }
                catch
                { }
            }

            this.Font = new Font(config.FontSegoeUI.Families[0], 7);
            txtEncryptedText.Font = new Font(config.FontSegoeUI.Families[0], 10);

            LoadNormalTextFontSettings();
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtNormalText.Font = f.Font;
                RecordLastUsedFont();
            }
        }

        void LoadNormalTextFontSettings()
        {
            bool fontOk = false;
            try
            {
                string file = Path.Combine(Environment.CurrentDirectory, "FontSettings");

                if (File.Exists(file))
                {
                    byte[] ba = File.ReadAllBytes(file);
                    Font font = (Font)ConvertByteArrayToObject(ba);
                    this.txtNormalText.Font = font;
                    fontOk = true;
                }
            }
            catch
            {
                fontOk = false;
            }

            if (!fontOk)
            {
                txtNormalText.Font = new Font(config.FontSegoeUI.Families[0], 10);
            }
        }

        void RecordLastUsedFont()
        {
            try
            {
                string file = Path.Combine(Environment.CurrentDirectory, "FontSettings");
                byte[] ba = ConvertObjectToByteArray(txtNormalText.Font);

                File.WriteAllBytes(file, ba);
            }
            catch
            { }
        }

        byte[] ConvertObjectToByteArray(object ob)
        {
            if (ob == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, ob);
            return ms.ToArray();
        }

        object ConvertByteArrayToObject(byte[] ba)
        {
            if (ba == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            Stream stream = new MemoryStream(ba);
            return bf.Deserialize(stream);
        }

        #endregion

        #region Encrypt

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                GC.Collect();
                if (txtNormalText.Text.Trim().Length == 0)
                {
                    toolTip2.Show(Language.MsgNormalTextIsEmpty, groupBoxNormal, txtNormalText.Location.X + 50, txtNormalText.Location.Y + 10, 2000);
                    txtEncryptedText.Clear();
                    return;
                }

                btEncrypt.Visible = false;
                btDecrypt.Visible = false;
                btEncrypt.Refresh();
                btDecrypt.Refresh();

                bwEncrypt.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        void bwEncrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DateTime timeStart = DateTime.Now;
                byte[] pwdBytes1 = Encoding.UTF8.GetBytes(txtPwd1.Text);
                byte[] pwdBytes2 = Encoding.UTF8.GetBytes(txtPwd2.Text);
                byte[] pwdBytes3 = Encoding.UTF8.GetBytes(txtPwd3.Text);
                byte[] pwdBytes4 = Encoding.UTF8.GetBytes(txtPwd4.Text);

                encryptedText = AES256BitExpress.Encrypt(txtNormalText.Text, pwdBytes1, pwdBytes2, pwdBytes3, pwdBytes4);

                DateTime timeEnd = DateTime.Now;
                TimeSpan timeElased = timeEnd - timeStart;
                timeUsed = string.Format(" (Encryption Time: = {0} milliseconds)", timeElased.TotalMilliseconds);
            }
            catch
            {
                MessageBox.Show(Language.ErrorEncryptFailDescription, Language.ErrorEncryptFail, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void bwEncrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.SuspendLayout();
                txtEncryptedText.Text = encryptedText;
                this.ResumeLayout();
                this.PerformLayout();
            }
            catch
            {
                MessageBox.Show(Language.ErrorEncryptFailDescription, Language.ErrorEncryptFail, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btEncrypt.Visible = true;
            btDecrypt.Visible = true;
        }

        #endregion

        #region Decrypt

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                GC.Collect();
                if (txtEncryptedText.Text.Trim().Length == 0)
                {
                    toolTip2.Show(Language.MsgEncryptedTextIsEmpty, groupBoxEncrypt, txtEncryptedText.Location.X + 50, txtEncryptedText.Location.Y + 10, 2000);
                    return;
                }

                btEncrypt.Visible = false;
                btDecrypt.Visible = false;
                btEncrypt.Refresh();
                btDecrypt.Refresh();

                bwDecrypt.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        void bwDecrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DateTime timeStart = DateTime.Now;
                byte[] pwdBytes1 = Encoding.UTF8.GetBytes(txtPwd1.Text);
                byte[] pwdBytes2 = Encoding.UTF8.GetBytes(txtPwd2.Text);
                byte[] pwdBytes3 = Encoding.UTF8.GetBytes(txtPwd3.Text);
                byte[] pwdBytes4 = Encoding.UTF8.GetBytes(txtPwd4.Text);

                normalText = AES256BitExpress.Decrypt(txtEncryptedText.Text, pwdBytes1, pwdBytes2, pwdBytes3, pwdBytes4);

                DateTime timeEnd = DateTime.Now;
                TimeSpan timeElased = timeEnd - timeStart;
                timeUsed = string.Format(" (Decryption Time: = {0} milliseconds)", timeElased.TotalMilliseconds);

                success = true;
            }
            catch
            {
                success = false;

                MessageBox.Show(Language.ErrorWrongPassword, Language.ErrorDecryptionFail, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void bwDecrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (success)
            {
                this.SuspendLayout();
                txtNormalText.Text = normalText;
                this.ResumeLayout();
                this.PerformLayout();
            }
            btEncrypt.Visible = true;
            btDecrypt.Visible = true;
        }

        #endregion

        #region Reset / Clear Textbox

        private void btResetAll_Click(object sender, EventArgs e)
        {
            btResetNormal.PerformClick();
            btResetPwd.PerformClick();
            btResetDecrypt.PerformClick();
        }

        private void btResetPwd_Click(object sender, EventArgs e)
        {
            txtPwd1.Clear();
            txtPwd2.Clear();
            txtPwd3.Clear();
            txtPwd4.Clear();
        }

        private void btResetNormal_Click(object sender, EventArgs e)
        {
            txtNormalText.Clear();
        }

        private void btResetDecrypt_Click(object sender, EventArgs e)
        {
            txtEncryptedText.Clear();
        }

        #endregion

        #region Copy, Paste

        private void btNormalCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard(txtNormalText);
        }

        private void btNormalPaste_Click(object sender, EventArgs e)
        {
            PasteToTextBox(txtNormalText);
        }

        private void btDecryptCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard(txtEncryptedText);
        }

        private void btDecryptPaste_Click(object sender, EventArgs e)
        {
            PasteToTextBox(txtEncryptedText);
        }

        void CopyToClipboard(TextBox textBox)
        {
            int trycount = 0;
            while (trycount < 3)
            {
                trycount += 1;
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetDataObject(textBox.Text, true);
                    return;
                }
                catch { }
            }
            MessageBox.Show(Language.ErrorCopy, Language.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void PasteToTextBox(TextBox textBox)
        {
            try
            {
                this.SuspendLayout();
                int i = textBox.SelectionStart;
                string clipboardText = Clipboard.GetText(TextDataFormat.UnicodeText);
                textBox.Text = textBox.Text.Insert(i, clipboardText);
                textBox.SelectionStart = i + clipboardText.Length;
                textBox.SelectionLength = 0;
                textBox.ScrollToCaret();
                textBox.Focus();
                this.ResumeLayout();
                this.PerformLayout();
            }
            catch
            {
                MessageBox.Show(Language.ErrorPaste, Language.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Misc

        private void btInfo_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }

        private void txtNormalText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtNormalText.SelectAll();
                e.Handled = true;
            }
        }

        private void txtEncryptedText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtEncryptedText.SelectAll();
                e.Handled = true;
            }
        }

        private void txtNormalText_TextChanged(object sender, EventArgs e)
        {
            groupBoxNormal.SuspendLayout();
            groupBoxNormal.Text = string.Format("{0} {1} {2} {3}", Language.NormalText, Language.Length, txtNormalText.TextLength, timeUsed);
            if (timeUsed.Length > 0)
                timeUsed = "";
            groupBoxNormal.ResumeLayout();
            groupBoxNormal.PerformLayout();
        }

        private void txtEncryptedText_TextChanged(object sender, EventArgs e)
        {
            groupBoxEncrypt.SuspendLayout();
            groupBoxEncrypt.Text = string.Format("{0} {1} {2} {3}", Language.EncryptedText, Language.Length, txtEncryptedText.TextLength, timeUsed);
            if (timeUsed.Length > 0)
                timeUsed = "";
            groupBoxEncrypt.ResumeLayout();
            groupBoxEncrypt.PerformLayout();
        }

        #endregion
    }
}
