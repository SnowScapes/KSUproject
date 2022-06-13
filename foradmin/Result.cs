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
    public partial class Result : MetroFramework.Forms.MetroForm
    {
        int surnum;
        public Result()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            using (MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
            {
                conn.Open();
                string searchsql = string.Format("SELECT * FROM survey_info WHERE UserNum = '{0}'", Main.usernum);
                MySqlCommand search = new MySqlCommand(searchsql, conn);
                MySqlDataReader reader = search.ExecuteReader();
                if (reader.Read())
                {
                    surnum = int.Parse(reader["surnum"].ToString());
                    for (int i = 0; i < int.Parse(reader["num"].ToString()); i++)
                    {
                        selectlist.Items.Add("항목" + (i+1).ToString());
                    }
                }
                reader.Close();
                conn.Close();
                resultlist.Columns.Add("선택지", 200, HorizontalAlignment.Left);
                resultlist.Columns.Add("투표인원", 70, HorizontalAlignment.Left);
                resultlist.View = View.Details;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(selectlist.SelectedIndex != -1)
            {
                resultlist.Items.Clear();
                using (MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
                {
                    conn.Open();
                    string searchsql = string.Format("SELECT * FROM survey_content WHERE connum = '{0}' AND surnum = '{1}'",selectlist.SelectedIndex,surnum);
                    MySqlCommand search = new MySqlCommand(searchsql, conn);
                    MySqlDataReader reader = search.ExecuteReader();
                    if (reader.Read())
                    {
                        int repcnt = int.Parse(reader["selcnt"].ToString());
                        reader.Close();
                        for (int i = 0; i < repcnt; i++)
                        {
                            searchsql = string.Format("SELECT * FROM survey_select WHERE surnum = '{0}' AND connum = '{1}' AND selnum = '{2}'",surnum, selectlist.SelectedIndex,i);
                            search = new MySqlCommand(searchsql, conn);
                            reader = search.ExecuteReader();
                            if (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["seltext"].ToString());
                                item.SubItems.Add(reader["count"].ToString());
                                resultlist.Items.Add(item);
                            }
                            reader.Close();
                        }
                    }
                    reader.Close();
                    conn.Close();
                }
            }
        }
    }
}
