using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControlsApp2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var FontsList = FontFamily.Families;
            foreach (var item in FontsList)
            {
                //CboFont.Items.Add(font.Name);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }


        /*private void ChangeFont()
        {
            if (CboFont.SlectedIndex < 0) return;

            FontStyle style = FontStyle.Regular;
            if (ChkBold.checked) style |= FontStyle.Bold;
                if (ChkItalic.Checked) style |= FontStyle.Italic;
                TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
        }*/
    }
}
