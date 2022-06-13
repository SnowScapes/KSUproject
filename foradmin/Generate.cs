using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace foradmin
{
    internal class Generate
    {
        public void GeneratePHP()
        {
            string path = @"C:\laragon\www\" + Main.user +".php";
            using (File.Create(path)) { }
            WritePHP(path);
        }
        public void DeletePHP()
        {
            string path = @"C:\laragon\www\" + Main.user + ".php";
            File.Delete(path);
        }
        public void WritePHP(string path)
        {
            StreamWriter writer;
            writer = File.AppendText(path);
            string end;
            using(MySqlConnection conn = new MySqlConnection(Main._connectionAddress))
            {
                conn.Open();
                string searchsql = string.Format("SELECT * FROM survey_info WHERE usernum = '{0}'", Main.usernum);
                MySqlCommand search = new MySqlCommand(searchsql, conn);
                MySqlDataReader reader = search.ExecuteReader();
                if(reader.Read())
                {
                    end = reader["end_content"].ToString();
                    int conrep = int.Parse(reader["num"].ToString());
                    int surnum = int.Parse(reader["surnum"].ToString());
                    writer.WriteLine("<div style=\"border: 1px solid #E5E2E1; margin: 0px 0px 15px 0px; padding: 10px;\">");
                    writer.WriteLine("<TABLE cellSpacing=0 cellPadding=0 width=\"1200\" border=0 bordercolor=\"#eeeeee\" bgcolor=\"#F1F2F6\" height=\"0%\">");
                    writer.WriteLine("<TR><TD><center>&nbsp; {0} &nbsp;<center></TD></TR>",reader["surname"].ToString());
                    writer.WriteLine("<TD width=\"1200\" height=\"40\" bordercolor=\"black\" bgcolor=\"#C7CFEF\" style='padding-top:8px'>");
                    writer.WriteLine("<P style=\"MARGIN-LEFT: 10px\" align=\"left\"><span style=\"font-size:9pt; \"><font color=\"#221E1F\">");
                    writer.WriteLine("* {0} </font></span></P></TD></TR>",reader["content"].ToString());
                    writer.WriteLine("<FORM name=\"form\" method=\"post\">");
                    writer.WriteLine("<td width=\"1200\" height=\"0%\">");
                    writer.WriteLine("<TABLE cellSpacing=0 borderColorDark=white width=\"1200\" borderColorLight=black border=\"0\" height=\"0%\">");
                    writer.WriteLine("<CAPTION align=bottom>\n<P style=\"MARGIN - LEFT: 0px; MARGIN - RIGHT: 0px\"></P></CAPTION><TBODY>");
                    reader.Close();
                    for (int i = 0; i < conrep; i++)
                    {
                        searchsql = String.Format("SELECT * FROM survey_content WHERE connum = '{0}' AND surnum = '{1}'",i,surnum);
                        search = new MySqlCommand(searchsql, conn);
                        reader = search.ExecuteReader();
                        if (reader.Read())
                        {
                            int connum = int.Parse(reader["connum"].ToString());
                            int selcnt = int.Parse(reader["selcnt"].ToString());
                            writer.WriteLine("<TR>\n<TD align=middle width=\"1200\" bgColor=\"#EFEFFB\" colSpan=3 height=15 style='padding-top:4px'>");
                            writer.WriteLine("<P style=\"MARGIN-LEFT: 0px; TEXT-INDENT: 6px; LINE-HEIGHT: 160 %; MARGIN-RIGHT: 0px\" align=justify>");
                            writer.WriteLine("<span style=\"font-size:9pt; color:#061873\">");
                            writer.WriteLine("{0}. {1}</span></P></TD></TR>\n<TR>", int.Parse(reader["connum"].ToString()) + 1, reader["context"].ToString());
                            writer.WriteLine("<TD vAlign=middle align=middle width=\"1200\" bgColor=white colSpan=3 height=40>");
                            writer.WriteLine("<P style=\"MARGIN-LEFT: 0px; MARGIN-RIGHT: 0px\" align=left>");
                            writer.WriteLine("<span style=\"font-size:9pt; color:#808284\">&nbsp;&nbsp;&nbsp;");
                            reader.Close();
                            for (int l = 0; l < selcnt; l++)
                            {
                                searchsql = String.Format("SELECT * FROM survey_select WHERE selnum = '{0}' AND connum = '{1}' AND surnum = '{2}'", l, connum, surnum);
                                search = new MySqlCommand(searchsql, conn);
                                reader = search.ExecuteReader();
                                if (reader.Read())
                                {
                                    writer.WriteLine("<INPUT type=radio name={0} value={1}>{2}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", i, l, reader["seltext"].ToString());
                                }
                                reader.Close();
                            }
                            writer.WriteLine("</span></P></TD></TR>");
                        }
                    }
                    writer.WriteLine("<TR>\n<TD vAlign=middle align=left width=\"1200\" bgColor=\"#C7CFEF\" height=30 style='padding-left:8px'>");
                    writer.WriteLine("<span style=\"font-size:9pt;\"><b><font color=\"#3D3D7D\"> {0} </font></b></span></TD></TR>",end);
                    writer.WriteLine("</TBODY></TABLE>");
                    writer.WriteLine("<P style=\"padding-bottom:10px\" align=\"center\"><FONT size=2><INPUT type=\"submit\" name=\"okay\" id=\"okay\" value=\" 설문조사종료 \"></FONT></P>");
                    writer.WriteLine("</TR></TABLE></div></FORM>");
                    writer.WriteLine("<?php\n$host = \"localhost\";\n$user = \"root\";\n$pw = \"root\";\n$dbname = \"foradmin\";\n$conn = new mysqli($host, $user, $pw, $dbname);");
                    writer.WriteLine("if(array_key_exists('okay',$_POST)) {\nfor ($i=0;$i<{0};$i++) {\nif(isset($_POST[$i])) {\n$sql = \"UPDATE survey_select SET count = count + 1 WHERE surnum = {1} AND connum = $i AND selnum = $_POST[$i]\";",conrep, surnum);
                    writer.WriteLine("$result = mysqli_query($conn, $sql);\n}\n}\necho \"<script>alert(\\\"설문 결과가 입력되었습니다.\\\");</script>\";\nmysqli_close($conn);\n}\n?>");
                    writer.Close();
                }
            }
        }
    }
}
