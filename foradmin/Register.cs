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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        
        private Login l = null;

        public Register(Login objLogin)
        {
            l = objLogin;
            InitializeComponent();
        }

        private void Reg_Btn_Click(object sender, EventArgs e)
        {
            
            if (RegID.Text.Trim() == "" || RegPW.Text.Trim() == "")
            {
                MessageBox.Show("ID 또는 PW 칸은 공백이 될 수 없습니다.");
            }
            else
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
                    {
                        conn.Open();
                        MySqlCommand search = new MySqlCommand("SELECT UserNUM,UserID FROM accounts;", conn);
                        MySqlDataReader rdr = search.ExecuteReader();
                        Boolean a = true;
                        int val = 0;
                        while (rdr.Read())
                        {
                            val = int.Parse(rdr["UserNUM"].ToString())+1;
                            if (rdr["UserID"].ToString() == RegID.Text)
                            {
                                a = false;
                                break;
                            }
                        }
                        rdr.Close();
                        if (a == false)
                            MessageBox.Show("이미 존재하는 ID 입니다.");
                        else
                        {
                            string insertQuery = string.Format("INSERT INTO accounts(UserNUM,UserID,UserPW) VALUES ('{0}','{1}','{2}');", val, RegID.Text, RegPW.Text);
                            MySqlCommand insert = new MySqlCommand(insertQuery, conn);
                            if (insert.ExecuteNonQuery() != 1)
                                MessageBox.Show("Failed to insert data.");
                            else
                            {
                                MessageBox.Show("계정이 생성되었습니다.");
                                this.Close();
                            }
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
}
