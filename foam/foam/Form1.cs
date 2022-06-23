using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace foam
{
    public partial class Form1 : Form
    {
        string fileName = "제목없음.txt";
        private bool modifyFlag = false;
        public Form1()
        {
            InitializeComponent();
            this.Text = "제목없음" + " - myNotePad";
        }
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "제목없음.txt")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt Files(*.txt)|*.txt";
                sfd.ShowDialog();
                fileName = sfd.FileName;
                this.Text
                  = Path.GetFileNameWithoutExtension(fileName) + " - myNotePad";
            }
            try
            {
                StreamWriter sw = File.CreateText(fileName);
                sw.WriteLine(txtMemo.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void 읽어오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 뭔가 수정이 되었다면, 작업중인 파일을 저장할 지 물어봐야 한다
            FileSaveProcess();
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName;
            openFileDialog1.Filter
              = "txt Files(*.txt)|*.txt|All Files(*.*)|*.*";
            try
            {
                StreamReader sr = new StreamReader(fileName);
                //this.Text = openFileDialog1.SafeFileName + " - myNotePad";
                this.Text = Path.GetFileNameWithoutExtension(fileName)
                    + " - myNotePad";
                txtMemo.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 뭔가 수정이 되었다면, 작업중인 파일을 저장할 지 물어봐야 한다
            FileSaveProcess();
            txtMemo.Text = "";
            fileName = "제목없음.txt";
            this.Text = "제목없음 - myNotePad";
        }
        // 뭔가 수정이 되었다면, 작업중인 파일을 저장할 지 물어봐야 한다
        private void FileSaveProcess()
        {
            if (modifyFlag == false)
                return;
            DialogResult answer =
              MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장",
              MessageBoxButtons.YesNoCancel);
            if (answer == DialogResult.Yes) // 작업중 파일을 저장
                if (fileName == "제목없음.txt")
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = File.CreateText(sfd.FileName);
                        sw.WriteLine(txtMemo.Text);
                        sw.Close();
                    }
                }
                else
                {
                    StreamWriter sw = File.CreateText(fileName);
                    sw.WriteLine(txtMemo.Text);
                    sw.Close();
                }
            else if (answer == DialogResult.No)
                return;
            else if (answer == DialogResult.Cancel)
                return;
        }
        private void 끝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 뭔가 수정이 되었다면, 작업중인 파일을 저장할 지 물어봐야 한다
            FileSaveProcess();
            this.Close();
        }
        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            modifyFlag = true;
        }
        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                txtMemo.Font = fontDialog1.Font;
        }
        private void 색상ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
                txtMemo.ForeColor = colorDialog1.Color;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3(this);
            c.Show();
        }
    }
}
