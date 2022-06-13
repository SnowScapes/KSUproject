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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "foradmin";
        string _id = "root";
        string _pw = "root";
        static internal string _connectionAddress = "";
        static internal string user;
        static internal int usernum;
        public Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
            Login l = new Login();
            l.ShowDialog();
            welcome.Text = user + " 님 환영합니다!";
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
                {
                    conn.Open();
                    string searchsql = string.Format("SELECT surname FROM survey_info WHERE UserNum = '{0}'", usernum);
                    MySqlCommand search = new MySqlCommand(searchsql, conn);
                    MySqlDataReader reader = search.ExecuteReader();
                    if (reader.Read() == true)
                        MessageBox.Show("이미 설문조사가 존재합니다.");
                    else
                    {
                        New n = new New();
                        n.ShowDialog();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("설문조사를 삭제하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
                {
                    conn.Open();
                    string deletesql = string.Format("DELETE FROM survey_info WHERE UserNum = '{0}'", usernum);
                    MySqlCommand delete = new MySqlCommand(deletesql, conn);
                    if (delete.ExecuteNonQuery() != 1)
                        MessageBox.Show("설문조사가 존재하지 않습니다.");
                    else
                    {
                        Generate g = new Generate();
                        g.DeletePHP();
                    }
                    conn.Close();
                }
            }
        }

        private void result_btn_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
            {
                conn.Open();
                string searchsql = string.Format("SELECT * FROM survey_info WHERE UserNum = '{0}'", usernum);
                MySqlCommand search = new MySqlCommand(searchsql, conn);
                MySqlDataReader reader = search.ExecuteReader();
                if(!reader.Read())
                    MessageBox.Show("생성된 설문조사가 없습니다.");
                else
                {
                    Result result = new Result();
                    result.Show();
                }
                conn.Close();
            }
        }
    }
}
