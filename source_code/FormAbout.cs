using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ctiencrypt
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            
            // An universal font that can display all languages in the world
            LoadEmbededFont();

            lbTitle.Text = Language.CTITextEncryption;
            lbDescription.Text = Language.AboutDescription;
        }

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

            this.Font = new Font(config.FontSegoeUI.Families[0], 9);
            lbTitle.Font = new Font(config.FontSegoeUI.Families[0], 12, FontStyle.Bold);
        }

    }
}
