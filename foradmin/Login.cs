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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        bool _isLogin = false;

        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            FormClosing += new FormClosingEventHandler(Notlogin);
        }

        private void Notlogin(object sender, FormClosingEventArgs e)
        {
            if(_isLogin == false)
                Application.Exit();
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
                {
                    conn.Open();
                    String searchSql = String.Format("SELECT UserNum,UserID,UserPW FROM accounts WHERE UserID = \"{0}\" AND UserPW = \"{1}\";", getID.Text, getPW.Text);
                    MySqlCommand search = new MySqlCommand(searchSql, conn);
                    MySqlDataReader reader = search.ExecuteReader();
                    if (reader.Read() == true) 
                    {
                        Main.usernum = int.Parse(reader["UserNum"].ToString());
                        Main.user = reader["UserID"].ToString();
                        MessageBox.Show("로그인 성공");
                        _isLogin = true;
                    }
                    else
                        MessageBox.Show("로그인 실패");
                    reader.Close();
                    conn.Close();
                    if (_isLogin == true)
                        this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
