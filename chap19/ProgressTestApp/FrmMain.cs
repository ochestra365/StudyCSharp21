using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProgressTestApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "시작";

            Thread th = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(500);
                }
                label1.Text = "종료";
            });//메인 UI 스레드에 들어간 것이다. 시행되면서 값이 안 돌아감.
            th.IsBackground = true;
            th.Start();
            th.Join();//해당 스레드를 가장 먼저 우선순위에 두겠다.
        }
    }
}
