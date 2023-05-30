using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.IO;
namespace ABLECSIS
{
    public partial class wfLogIn : Form
    {
        public static MySqlConnection c = new MySqlConnection
              ("server = localhost; uid = root; pwd = ; database = leoncio;");
        public static MySqlDataAdapter d = new MySqlDataAdapter();
        public static DataTable t;
        public static String q;
        public static void vSelect()
        {
            t = new DataTable();
            d.SelectCommand = new MySqlCommand(q, c);
            d.Fill(t);
        }
        public wfLogIn()
        {
            InitializeComponent();
        }
        private void wfLogIn_Load(object sender, EventArgs e)
        {
            CancelButton = bnCancel;
            AcceptButton = bnLogIn;
            q = "select userid from user";
            vSelect();
            wfCreateUser.sUtype = "Staff";
            if (t.Rows.Count == 0)
            {
                wfCreateUser.sUtype = "Admin";
                MessageBox.Show("No user information has been found. Please create one to use this system."
                    , "No Information has been found"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                wfCreateUser u = new wfCreateUser();
                u.ShowDialog();
                wfLogIn_Load(sender, e);
            }
            q = "SELECT logout FROM loghis order by logid desc limit 1";
            vSelect();
            if (t.Rows[0][0].ToString() == "")
            {
                q = "update loghis set logout = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    + "' order by logid desc limit 1";
                vSelect();
            }
            txtPword.Text = "Leoncio";
            txtUname.Text = "Leoncio";
        }
        public static String dbuserid;
        public static String dbuname;
        public static String dbpwd;
        public static String dbfname;
        public static String dblname;
        public static String dbustatus;
        public static String dbutype;
        public static String dbsq;
        public static String dbsa;
        public static String dbregdate;
        private void bnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUname.Text.Length < 6 || txtUname.Text.Length > 20)
            {
                MessageBox.Show("Username must be at least six (6) to twenty (20) characters."
                    , "Invalid Username");
                txtUname.Focus();
            }
            else if (txtPword.Text.Length < 6 || txtPword.Text.Length > 20)
            {
                MessageBox.Show("Password must be at least six (6) to twenty (20) characters."
                    , "Invalid Password");
                txtPword.Focus();
            }
            else
            {
                q = "Select * from user where uname = '" + txtUname.Text
                    + "' and pwd = '" + txtPword.Text + "'";
                vSelect();
                if (t.Rows.Count > 0)
                {
                    dbuserid = t.Rows[0][0].ToString();
                    dbuname = t.Rows[0][1].ToString();
                    dbpwd = t.Rows[0][2].ToString();
                    dbfname = t.Rows[0][3].ToString();
                    dblname = t.Rows[0][4].ToString();
                    dbustatus = t.Rows[0][5].ToString();
                    dbutype = t.Rows[0][6].ToString();
                    dbsq = t.Rows[0][7].ToString();
                    dbsa = t.Rows[0][8].ToString();
                    dbregdate = t.Rows[0][9].ToString();
                    if (txtUname.Text == dbuname)
                    {
                        if (dbustatus == "Active")
                        {
                            bLog = true;
                            dLogIn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            q = "SELECT logid FROM loghis where login like '" + DateTime.Now.ToString("yyyy") + "%'";
                            vSelect();
                            q = "insert into loghis values ('" + DateTime.Now.ToString("yyyy-") + (t.Rows.Count + 1).ToString("d5")
                                + "','" + dbuserid
                                + "','" + dLogIn
                                + "',null)";
                            vSelect();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Your account is currently blocked!, Please contact your administrator", "Blocked Account");
                            Close();
                            bLog = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password doesn't Exist!"
                        , "Invalid Username or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password doesn't Exist!"
                        , "Invalid Username or Password");
                }
                txtUname.Clear();
                txtPword.Clear();
                txtUname.Focus();
            }
        }
        public static String dLogIn;
        public static Boolean bLog;//for allowing or not to close the application wfLogin form
        public static Boolean bExit;//for allowing or not to exit the application wfHome form
        private void bnCancel_Click(object sender, EventArgs e)
        {
            bLog = false;
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            wfForgotPassword p = new wfForgotPassword();
            p.ShowDialog();
            Show();
        }
        private void wfLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bLog == true)
                bExit = false;
            else
                bExit = true;
        }
    }
}