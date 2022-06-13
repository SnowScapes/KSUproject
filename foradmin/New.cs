using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace foradmin
{
    public partial class New : MetroFramework.Forms.MetroForm
    {
        bool end = false;
        int val;
        public New()
        {
            InitializeComponent();
            get.Visible = false;
            this.FormClosing += new FormClosingEventHandler(close);
        }
        private void close(object sender, FormClosingEventArgs e)
        {
            if (end == false)
            {
                if (MessageBox.Show("진행사항이 저장되지 않습니다.\n종료하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
                        {
                            conn.Open();
                            string searchsql = string.Format("SELECT UserNum FROM survey_info WHERE UserNum = '{0}'", Main.usernum);
                            MySqlCommand search = new MySqlCommand(searchsql, conn);
                            MySqlDataReader reader = search.ExecuteReader();
                            if (reader.Read())
                            {
                                reader.Close();
                                string Del = String.Format("DELETE FROM survey_info WHERE UserNum = '{0}'", Main.usernum);
                                MySqlCommand delete = new MySqlCommand(Del, conn);
                                if (delete.ExecuteNonQuery() != 1)
                                    MessageBox.Show("Failed to delete data.");
                            }
                            conn.Close();
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || purpose.Text == "" || num.Text == "" || goodbye.Text == "")
                MessageBox.Show("작성되지 않은 칸이 있습니다.");
            else
            {
                get.Visible = true;
                for (int i = 0; i < int.Parse(num.Text); i++)
                {
                    itemlist.Items.Add("항목 " + (i + 1));
                }
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
                    {
                        conn.Open();
                        string searchQuery = string.Format("SELECT surnum FROM survey_info");
                        MySqlCommand search = new MySqlCommand(searchQuery, conn);
                        MySqlDataReader reader = search.ExecuteReader();
                        if (!reader.Read())
                        {
                            val = 0;
                        }
                        else
                        {
                            reader.Close();
                            searchQuery = String.Format("SELECT MAX(surnum) FROM survey_info");
                            search = new MySqlCommand(searchQuery, conn);
                            reader = search.ExecuteReader();
                            if (reader.Read())
                                val = int.Parse(reader["MAX(surnum)"].ToString()) + 1;
                        }
                        reader.Close();
                        string insertQuery = string.Format("INSERT INTO survey_info(UserNum,surnum,surname,content,num,end_content) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", Main.usernum, val, name.Text, purpose.Text, num.Text, goodbye.Text);
                        MySqlCommand insert = new MySqlCommand(insertQuery, conn);
                        if (insert.ExecuteNonQuery() != 1)
                            MessageBox.Show("Failed to insert data.");
                        for (int i = 0; i < int.Parse(num.Text); i++)
                        {
                            insertQuery = String.Format("INSERT INTO survey_content(surnum,connum,context,selcnt) VALUES ('{0}','{1}',NULL,NULL)", val, i);
                            insert = new MySqlCommand(insertQuery, conn);
                            if (insert.ExecuteNonQuery() != 1)
                                MessageBox.Show("Failed to insert data.");
                        }
                        conn.Close();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("진행사항이 저장되지 않습니다.\n기본정보를 수정하시겠습니까?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                itemlist.Items.Clear();
                sellist.Clear();
                item.Clear();
                get.Visible = false;
                try
                {
                    using(MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
                    {
                        conn.Open();
                        string Del = String.Format("DELETE FROM survey_info WHERE surnum = '{0}'", val);
                        MySqlCommand delete = new MySqlCommand(Del, conn);
                        if (delete.ExecuteNonQuery() != 1)
                            MessageBox.Show("Failed to delete data.");
                        conn.Close ();
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection (Main._connectionAddress))
                {
                    conn.Open ();
                    string updateQuery = string.Format("UPDATE survey_content SET context = '{0}' ,selcnt = '{1}' WHERE connum = '{2}' AND surnum = '{3}';", item.Text, sellist.Items.Count, itemlist.SelectedIndex, val);
                    MySqlCommand update = new MySqlCommand(updateQuery, conn);
                    if (update.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to update data");
                    for (int i = 0; i < sellist.Items.Count; i++)
                    {
                        string insertQuery = string.Format("INSERT INTO survey_select(surnum,connum,selnum,seltext,count) VALUES ('{0}','{1}','{2}','{3}','{4}')", val, itemlist.SelectedIndex, i, sellist.Items[i].Text,'0');
                        MySqlCommand insert = new MySqlCommand(insertQuery, conn);
                        if (insert.ExecuteNonQuery() != 1)
                            MessageBox.Show("Failed to insert data");
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            sellist.Clear();
            item.Clear();
            MessageBox.Show(String.Format("항목 {0}번이 저장되었습니다.",itemlist.SelectedIndex+1));
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (seltext.Text == "")
                MessageBox.Show("내용을 입력해주세요.");
            else
            {
                sellist.Items.Add(seltext.Text);
                seltext.Text = "";
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            sellist.Items.RemoveAt(sellist.FocusedItem.Index);
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("설문조사를 작성하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                end = true;
                Generate g = new Generate();
                g.GeneratePHP();
                this.Close();
            }
        }
    }
}
