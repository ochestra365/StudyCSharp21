using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopyAPp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//겁나 많이 쓰이는 소스
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtSource.Text = dialog.FileName;
            }
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtTarget.Text = dialog.FileName;
            }
        }

        private async void BtnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyAsync(TxtSource.Text, TxtTarget.Text);
            MessageBox.Show($"{totalCopied}로 복사했습니다.", "비동기복사완료");
        }

        private void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = Copysync(TxtSource.Text, TxtTarget.Text);//동기파일 복사
            MessageBox.Show($"{totalCopied}로 복사했습니다.", "동기복사완료");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소");
        }

        private long Copysync(string sourcePath, string targetPath)
        {
            BtnAsyncCopy.Enabled = false;//비동기버튼 비활성화(Enable vs Disable)
            long totalCopied = 0;//전부 복사했는 지 확인

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))//존재하는 파일
            {
                using(FileStream targetStream = new FileStream(targetPath, FileMode.Create))//새로 생성
                {
                    byte[] buffer = new byte[1024*1024]; // 1024(1KB)*1024=>1MB
                    int nRead = 0;
                    while ((nRead=sourceStream.Read(buffer,0,buffer.Length)) != 0)//1MB씩 읽어서 데이터를 흡수하겠다.
                    {
                        targetStream.Write(buffer, 0, nRead);//복사 위치
                        totalCopied += nRead;

                        //프로그레스바에 복사 상태 진행표시
                        PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100);
                    }
                }
            }
            //괄호를 통해 이 모든 연산 작용이 알아서 Close되는 것이다.
            //byte의 배열이 버퍼이다.
            //Stream은 데이터가 물결로 흘러서 쭉 가는 것을 의미한다.
            //sourcestream이 targetStream을 다 복사해야 한다.
            //copy 끝나면
            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }
        /// <summary>
        /// 비동기 복사
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="targetPath"></param>
        /// <returns></returns>
        private async Task<long> CopyAsync(string sourcePath, string targetPath)
        {
            BtnSyncCopy.Enabled = false;
            long totalCopied = 0;//전부 복사했는 지 확인

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))//존재하는 파일
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create))//새로 생성
                {
                    byte[] buffer = new byte[1024 * 1024]; // 1024(1KB)*1024=>1MB
                    int nRead = 0;
                    while ((nRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)//1MB씩 읽어서 데이터를 흡수하겠다.
                    {
                        await targetStream.WriteAsync(buffer, 0, nRead);//복사 위치
                        totalCopied += nRead;

                        //프로그레스바에 복사 상태 진행표시
                        PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100);
                    }
                }
            }
           
            BtnSyncCopy.Enabled = true;
            return totalCopied;
        }
    }
}
