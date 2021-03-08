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
        Random random = new Random(37);

        public FrmMain()
        {
            InitializeComponent();
        }

        #region 이벤트핸들러 영역
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LsvDummy.Columns.Add("Name");
            LsvDummy.Columns.Add("Depth");

            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                comboBox1.Items.Add(font.Name);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrbDisplay.Value = TrbHandle.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form
            {
                Text = "Modal Form",
                Width = 300,
                Height = 100,
                BackColor = Color.Coral
            };
            frm.ShowDialog();//모달창 띄우기. 모든 권한을 자식한테 다 주는 것이다.
            //일반적으로 알고 있는 메세지 팝업. 새로운 창을 또 열고 싶을 때 쓰는 것이다.
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form
            {
                Text = "Modaless Form",
                Width = 300,
                Height = 100,
                BackColor = Color.GreenYellow
            };
            frm.ShowDialog();//모달창 띄우기. 모든 권한을 자식한테 다 주는 것이다.
            //일반적으로 알고 있는 메세지 팝업. 새로운 창을 또 열고 싶을 때 쓰는 것이다.
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            //모달창 메세지 박스
            MessageBox.Show(textBox1.Text, "타이틀", MessageBoxButtons.YesNo, MessageBoxIcon.Error);//모달창
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(random.Next().ToString());

            DisplayTreeToList();
        }

        private void BTnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            TrvDummy.SelectedNode.Expand();//펼치는 거

            DisplayTreeToList();
        }
        #endregion

        #region 사용자 메서드 영역
        private void ChangeFont()
        {
            if (comboBox1.SelectedIndex < 0) return; // 콤보박스에 아무것도 선택안했으면(-1) 메서드 탈출

            FontStyle style = FontStyle.Regular; // 00000000
            if (checkBox1.Checked) style |= FontStyle.Bold;  // 00000001 
            if (checkBox2.Checked) style |= FontStyle.Italic; // 00000010   
                                                              // 00000001 | 00000010  = 00000011 = Bold + Italic 00001111 8+4+2+1
            textBox1.Font = new Font((string)comboBox1.SelectedItem, 14, style);
        }
        #endregion
        /// <summary>
        /// 트리뷰 내용 리스트뷰에 표시
        /// </summary>
        private void DisplayTreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                DisplayTreeToList(node);
            }
        }

        private void DisplayTreeToList(TreeNode node)
        {
            LsvDummy.Items.Add(new ListViewItem(new string[] {node.Text, node.FullPath}));

            foreach (TreeNode item in node.Nodes)
            {
                DisplayTreeToList(item);//재귀호출
            }
        }
    }
}
