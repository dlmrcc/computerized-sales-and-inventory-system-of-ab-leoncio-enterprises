using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABLECSIS
{
    public partial class wfChangeUser : Form
    {
        public wfChangeUser()
        {
            InitializeComponent();
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length < 6 || txtUsername.Text.Length > 20)
            {
                MessageBox.Show("Username must be at least six (6) to twenty (20) characters."
                    , "Invalid Username");
                txtUsername.Focus();
            }
            else if (txtNewPass.Text.Length < 6 || txtNewPass.Text.Length > 20)
            {
                MessageBox.Show("New Password must be at least six (6) to twenty (20) characters."
                    , "Invalid New Password");
                txtNewPass.Focus();
            }
            else if (txtConfirmPass.Text.Length < 6 || txtConfirmPass.Text.Length > 20)
            {
                MessageBox.Show("Confirm Password must be at least six (6) to twenty (20) characters."
                   , "Invalid Confirm Password");
                txtConfirmPass.Focus();
            }
            else if (txtFname.Text.Length < 2 || txtFname.Text.Length > 20)
            {
                MessageBox.Show("Firstname must be at least two (6) to thirty (30) characters."
                  , "Invalid Firstname");
                txtFname.Focus();
            }
            else if (txtLname.Text.Length < 2 || txtLname.Text.Length > 20)
            {
                MessageBox.Show("Lastname must be at least  six (6) to twenty (20) characters."
                  , "Invalid Lastname");
                txtLname.Focus();
            }
            else
            {
                wfLogIn.q = "select uname, concat(lname, fname) from user where uname = '" + txtUsername.Text
                    + "' or concat(fname,lname) = '" + txtFname.Text + txtLname.Text + "'";
                wfLogIn.vSelect();
                if (wfLogIn.t.Rows.Count > 0)
                {
                    if ((wfLogIn.t.Rows[0][0].ToString() == wfLogIn.dbuname &&
                          wfLogIn.t.Rows[0][1].ToString() == wfLogIn.dbfname + wfLogIn.dblname)
                        || wfLogIn.t.Rows.Count == 1)
                    {
                        vEdit();
                    }
                    else
                    {
                        MessageBox.Show("Username or Fullname is already exist.", "Unable to create an account");
                        txtUsername.Focus();
                    }
                }
                else
                {
                    vEdit();
                }
            }
        }
        void vEdit()
        {
            wfPassword p = new wfPassword();
            p.ShowDialog();
            if (wfPassword.sCurrentPassword != "")
            {
                wfLogIn.q = "update user set pwd = '" + txtNewPass.Text
                    + "',uname = '" + txtUsername.Text
                    + "',fname = '" + txtFname.Text
                    + "',lname = '" + txtLname.Text
                    + "' where userid = '" + wfLogIn.dbuserid + "'";
                wfLogIn.vSelect();
                MessageBox.Show("Changes has been successfully saved.", "Saved Completed");
                wfLogIn.dbpwd = txtNewPass.Text;
                wfLogIn.dbuname = txtUsername.Text;
                wfLogIn.dbfname = txtFname.Text;
                wfLogIn.dblname = txtLname.Text;
                Close();
            }
        }
        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfChangeUser_Load(object sender, EventArgs e)
        {
            Text = "Change Personal Information";
            txtUsername.Text = wfLogIn.dbuname;
            txtLname.Text = wfLogIn.dblname;
            txtFname.Text = wfLogIn.dbfname;
        }
    }
}