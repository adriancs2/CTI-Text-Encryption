namespace ctiencrypt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btInfo = new System.Windows.Forms.Button();
            this.lbPwd1 = new System.Windows.Forms.Label();
            this.btResetPwd = new System.Windows.Forms.Button();
            this.lbPwd2 = new System.Windows.Forms.Label();
            this.txtPwd4 = new System.Windows.Forms.TextBox();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.txtPwd3 = new System.Windows.Forms.TextBox();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.lbPwd4 = new System.Windows.Forms.Label();
            this.lbPwd3 = new System.Windows.Forms.Label();
            this.btResetAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.btDecryptCopy = new System.Windows.Forms.Button();
            this.btDecryptPaste = new System.Windows.Forms.Button();
            this.btResetDecrypt = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btEncrypt = new System.Windows.Forms.Button();
            this.btNormalCopy = new System.Windows.Forms.Button();
            this.btNormalPaste = new System.Windows.Forms.Button();
            this.btResetNormal = new System.Windows.Forms.Button();
            this.btFont = new System.Windows.Forms.Button();
            this.groupBoxNormal = new System.Windows.Forms.GroupBox();
            this.txtNormalText = new System.Windows.Forms.TextBox();
            this.groupBoxEncrypt = new System.Windows.Forms.GroupBox();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxNormal.SuspendLayout();
            this.groupBoxEncrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.btInfo, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbPwd1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btResetPwd, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbPwd2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtPwd4, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtPwd1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtPwd3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtPwd2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbPwd4, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbPwd3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btResetAll, 5, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(721, 56);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btInfo
            // 
            this.btInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfo.Image = global::ctiencrypt.Properties.Resources.info25;
            this.btInfo.Location = new System.Drawing.Point(620, 10);
            this.btInfo.Margin = new System.Windows.Forms.Padding(5);
            this.btInfo.Name = "btInfo";
            this.tableLayoutPanel4.SetRowSpan(this.btInfo, 2);
            this.btInfo.Size = new System.Drawing.Size(96, 35);
            this.btInfo.TabIndex = 19;
            this.btInfo.Text = "Info";
            this.btInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // lbPwd1
            // 
            this.lbPwd1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPwd1.AutoSize = true;
            this.lbPwd1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPwd1.Location = new System.Drawing.Point(3, 7);
            this.lbPwd1.Name = "lbPwd1";
            this.lbPwd1.Size = new System.Drawing.Size(45, 13);
            this.lbPwd1.TabIndex = 0;
            this.lbPwd1.Text = "lbPwd1";
            // 
            // btResetPwd
            // 
            this.btResetPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btResetPwd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetPwd.Image = global::ctiencrypt.Properties.Resources.reset25;
            this.btResetPwd.Location = new System.Drawing.Point(353, 10);
            this.btResetPwd.Margin = new System.Windows.Forms.Padding(5);
            this.btResetPwd.Name = "btResetPwd";
            this.tableLayoutPanel4.SetRowSpan(this.btResetPwd, 2);
            this.btResetPwd.Size = new System.Drawing.Size(137, 35);
            this.btResetPwd.TabIndex = 5;
            this.btResetPwd.Text = "Erase Password";
            this.btResetPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btResetPwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btResetPwd.UseVisualStyleBackColor = true;
            this.btResetPwd.Click += new System.EventHandler(this.btResetPwd_Click);
            // 
            // lbPwd2
            // 
            this.lbPwd2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPwd2.AutoSize = true;
            this.lbPwd2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPwd2.Location = new System.Drawing.Point(3, 35);
            this.lbPwd2.Name = "lbPwd2";
            this.lbPwd2.Size = new System.Drawing.Size(45, 13);
            this.lbPwd2.TabIndex = 3;
            this.lbPwd2.Text = "lbPwd2";
            // 
            // txtPwd4
            // 
            this.txtPwd4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd4.Location = new System.Drawing.Point(228, 31);
            this.txtPwd4.Name = "txtPwd4";
            this.txtPwd4.PasswordChar = '*';
            this.txtPwd4.Size = new System.Drawing.Size(117, 22);
            this.txtPwd4.TabIndex = 4;
            this.txtPwd4.UseSystemPasswordChar = true;
            // 
            // txtPwd1
            // 
            this.txtPwd1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd1.Location = new System.Drawing.Point(54, 3);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.PasswordChar = '*';
            this.txtPwd1.Size = new System.Drawing.Size(117, 22);
            this.txtPwd1.TabIndex = 1;
            this.txtPwd1.UseSystemPasswordChar = true;
            // 
            // txtPwd3
            // 
            this.txtPwd3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd3.Location = new System.Drawing.Point(228, 3);
            this.txtPwd3.Name = "txtPwd3";
            this.txtPwd3.PasswordChar = '*';
            this.txtPwd3.Size = new System.Drawing.Size(117, 22);
            this.txtPwd3.TabIndex = 3;
            this.txtPwd3.UseSystemPasswordChar = true;
            // 
            // txtPwd2
            // 
            this.txtPwd2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd2.Location = new System.Drawing.Point(54, 31);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(117, 22);
            this.txtPwd2.TabIndex = 2;
            this.txtPwd2.UseSystemPasswordChar = true;
            // 
            // lbPwd4
            // 
            this.lbPwd4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPwd4.AutoSize = true;
            this.lbPwd4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPwd4.Location = new System.Drawing.Point(177, 35);
            this.lbPwd4.Name = "lbPwd4";
            this.lbPwd4.Size = new System.Drawing.Size(45, 13);
            this.lbPwd4.TabIndex = 5;
            this.lbPwd4.Text = "lbPwd4";
            // 
            // lbPwd3
            // 
            this.lbPwd3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPwd3.AutoSize = true;
            this.lbPwd3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPwd3.Location = new System.Drawing.Point(177, 7);
            this.lbPwd3.Name = "lbPwd3";
            this.lbPwd3.Size = new System.Drawing.Size(45, 13);
            this.lbPwd3.TabIndex = 4;
            this.lbPwd3.Text = "lbPwd3";
            // 
            // btResetAll
            // 
            this.btResetAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btResetAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetAll.Image = global::ctiencrypt.Properties.Resources.reset25;
            this.btResetAll.Location = new System.Drawing.Point(500, 10);
            this.btResetAll.Margin = new System.Windows.Forms.Padding(5);
            this.btResetAll.Name = "btResetAll";
            this.tableLayoutPanel4.SetRowSpan(this.btResetAll, 2);
            this.btResetAll.Size = new System.Drawing.Size(110, 35);
            this.btResetAll.TabIndex = 18;
            this.btResetAll.Text = "Erase All";
            this.btResetAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btResetAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btResetAll.UseVisualStyleBackColor = true;
            this.btResetAll.Click += new System.EventHandler(this.btResetAll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxNormal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxEncrypt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 561);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btDecrypt);
            this.flowLayoutPanel2.Controls.Add(this.btDecryptCopy);
            this.flowLayoutPanel2.Controls.Add(this.btDecryptPaste);
            this.flowLayoutPanel2.Controls.Add(this.btResetDecrypt);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(786, 379);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(94, 178);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // btDecrypt
            // 
            this.btDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btDecrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecrypt.Image = global::ctiencrypt.Properties.Resources.btDecrypt;
            this.btDecrypt.Location = new System.Drawing.Point(3, 3);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(85, 35);
            this.btDecrypt.TabIndex = 13;
            this.btDecrypt.Text = "Decrypt";
            this.btDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // btDecryptCopy
            // 
            this.btDecryptCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDecryptCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecryptCopy.Image = global::ctiencrypt.Properties.Resources.copy24;
            this.btDecryptCopy.Location = new System.Drawing.Point(3, 44);
            this.btDecryptCopy.Name = "btDecryptCopy";
            this.btDecryptCopy.Size = new System.Drawing.Size(85, 35);
            this.btDecryptCopy.TabIndex = 14;
            this.btDecryptCopy.Text = "Copy";
            this.btDecryptCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDecryptCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDecryptCopy.UseVisualStyleBackColor = true;
            this.btDecryptCopy.Click += new System.EventHandler(this.btDecryptCopy_Click);
            // 
            // btDecryptPaste
            // 
            this.btDecryptPaste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDecryptPaste.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecryptPaste.Image = global::ctiencrypt.Properties.Resources.paste24;
            this.btDecryptPaste.Location = new System.Drawing.Point(3, 85);
            this.btDecryptPaste.Name = "btDecryptPaste";
            this.btDecryptPaste.Size = new System.Drawing.Size(85, 35);
            this.btDecryptPaste.TabIndex = 16;
            this.btDecryptPaste.Text = "Paste";
            this.btDecryptPaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDecryptPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDecryptPaste.UseVisualStyleBackColor = true;
            this.btDecryptPaste.Click += new System.EventHandler(this.btDecryptPaste_Click);
            // 
            // btResetDecrypt
            // 
            this.btResetDecrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btResetDecrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetDecrypt.Image = global::ctiencrypt.Properties.Resources.reset25;
            this.btResetDecrypt.Location = new System.Drawing.Point(3, 126);
            this.btResetDecrypt.Name = "btResetDecrypt";
            this.btResetDecrypt.Size = new System.Drawing.Size(85, 35);
            this.btResetDecrypt.TabIndex = 17;
            this.btResetDecrypt.Text = "Erase";
            this.btResetDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btResetDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btResetDecrypt.UseVisualStyleBackColor = true;
            this.btResetDecrypt.Click += new System.EventHandler(this.btResetDecrypt_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btEncrypt);
            this.flowLayoutPanel1.Controls.Add(this.btNormalCopy);
            this.flowLayoutPanel1.Controls.Add(this.btNormalPaste);
            this.flowLayoutPanel1.Controls.Add(this.btResetNormal);
            this.flowLayoutPanel1.Controls.Add(this.btFont);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(786, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(94, 306);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btEncrypt
            // 
            this.btEncrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEncrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncrypt.Image = global::ctiencrypt.Properties.Resources.btEncrypt;
            this.btEncrypt.Location = new System.Drawing.Point(3, 3);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(85, 35);
            this.btEncrypt.TabIndex = 7;
            this.btEncrypt.Text = "Encrypt";
            this.btEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEncrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEncrypt.UseVisualStyleBackColor = true;
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // btNormalCopy
            // 
            this.btNormalCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNormalCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNormalCopy.Image = global::ctiencrypt.Properties.Resources.copy24;
            this.btNormalCopy.Location = new System.Drawing.Point(3, 44);
            this.btNormalCopy.Name = "btNormalCopy";
            this.btNormalCopy.Size = new System.Drawing.Size(85, 35);
            this.btNormalCopy.TabIndex = 8;
            this.btNormalCopy.Text = "Copy";
            this.btNormalCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNormalCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNormalCopy.UseVisualStyleBackColor = true;
            this.btNormalCopy.Click += new System.EventHandler(this.btNormalCopy_Click);
            // 
            // btNormalPaste
            // 
            this.btNormalPaste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNormalPaste.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNormalPaste.Image = global::ctiencrypt.Properties.Resources.paste24;
            this.btNormalPaste.Location = new System.Drawing.Point(3, 85);
            this.btNormalPaste.Name = "btNormalPaste";
            this.btNormalPaste.Size = new System.Drawing.Size(85, 35);
            this.btNormalPaste.TabIndex = 10;
            this.btNormalPaste.Text = "Paste";
            this.btNormalPaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNormalPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNormalPaste.UseVisualStyleBackColor = true;
            this.btNormalPaste.Click += new System.EventHandler(this.btNormalPaste_Click);
            // 
            // btResetNormal
            // 
            this.btResetNormal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btResetNormal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetNormal.Image = global::ctiencrypt.Properties.Resources.reset25;
            this.btResetNormal.Location = new System.Drawing.Point(3, 126);
            this.btResetNormal.Name = "btResetNormal";
            this.btResetNormal.Size = new System.Drawing.Size(85, 35);
            this.btResetNormal.TabIndex = 11;
            this.btResetNormal.Text = "Erase";
            this.btResetNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btResetNormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btResetNormal.UseVisualStyleBackColor = true;
            this.btResetNormal.Click += new System.EventHandler(this.btResetNormal_Click);
            // 
            // btFont
            // 
            this.btFont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFont.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFont.Image = global::ctiencrypt.Properties.Resources.buttonFont;
            this.btFont.Location = new System.Drawing.Point(3, 167);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(85, 35);
            this.btFont.TabIndex = 12;
            this.btFont.Text = "Font";
            this.btFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // groupBoxNormal
            // 
            this.groupBoxNormal.Controls.Add(this.txtNormalText);
            this.groupBoxNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNormal.Location = new System.Drawing.Point(4, 66);
            this.groupBoxNormal.Name = "groupBoxNormal";
            this.groupBoxNormal.Size = new System.Drawing.Size(775, 306);
            this.groupBoxNormal.TabIndex = 2;
            this.groupBoxNormal.TabStop = false;
            this.groupBoxNormal.Text = "Normal Text. Length: 0";
            // 
            // txtNormalText
            // 
            this.txtNormalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNormalText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNormalText.Location = new System.Drawing.Point(3, 16);
            this.txtNormalText.MaxLength = 2147483647;
            this.txtNormalText.Multiline = true;
            this.txtNormalText.Name = "txtNormalText";
            this.txtNormalText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNormalText.Size = new System.Drawing.Size(769, 287);
            this.txtNormalText.TabIndex = 6;
            this.txtNormalText.WordWrap = false;
            this.txtNormalText.TextChanged += new System.EventHandler(this.txtNormalText_TextChanged);
            this.txtNormalText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNormalText_KeyDown);
            // 
            // groupBoxEncrypt
            // 
            this.groupBoxEncrypt.Controls.Add(this.txtEncryptedText);
            this.groupBoxEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEncrypt.Location = new System.Drawing.Point(4, 379);
            this.groupBoxEncrypt.Name = "groupBoxEncrypt";
            this.groupBoxEncrypt.Size = new System.Drawing.Size(775, 178);
            this.groupBoxEncrypt.TabIndex = 4;
            this.groupBoxEncrypt.TabStop = false;
            this.groupBoxEncrypt.Text = "Encrypted Text. Length: 0";
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.BackColor = System.Drawing.Color.OldLace;
            this.txtEncryptedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEncryptedText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedText.Location = new System.Drawing.Point(3, 16);
            this.txtEncryptedText.MaxLength = 2147483647;
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEncryptedText.Size = new System.Drawing.Size(769, 159);
            this.txtEncryptedText.TabIndex = 12;
            this.txtEncryptedText.WordWrap = false;
            this.txtEncryptedText.TextChanged += new System.EventHandler(this.txtEncryptedText_TextChanged);
            this.txtEncryptedText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEncryptedText_KeyDown);
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 405);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTI Text Encryption";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxNormal.ResumeLayout(false);
            this.groupBoxNormal.PerformLayout();
            this.groupBoxEncrypt.ResumeLayout(false);
            this.groupBoxEncrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.Label lbPwd1;
        private System.Windows.Forms.TextBox txtPwd4;
        private System.Windows.Forms.TextBox txtPwd3;
        private System.Windows.Forms.Label lbPwd4;
        private System.Windows.Forms.Label lbPwd3;
        private System.Windows.Forms.Label lbPwd2;
        private System.Windows.Forms.Button btResetPwd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxNormal;
        private System.Windows.Forms.TextBox txtNormalText;
        private System.Windows.Forms.GroupBox groupBoxEncrypt;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Button btResetAll;
        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btNormalCopy;
        private System.Windows.Forms.Button btNormalPaste;
        private System.Windows.Forms.Button btResetNormal;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btDecryptCopy;
        private System.Windows.Forms.Button btDecryptPaste;
        private System.Windows.Forms.Button btResetDecrypt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btFont;
    }
}

