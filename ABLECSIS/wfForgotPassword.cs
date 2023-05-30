using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABLECSIS
{
    public partial class wfForgotPassword : Form
    {
        public wfForgotPassword()
        {
            InitializeComponent();
        }
        String dbPassword;
        String dbSecAns;
        private void bnUserOk_Click(object sender, EventArgs e)
        {
            if (txtUsername.Enabled == true)
            {
                if (txtUsername.Text.Length < 6 || txtUsername.Text.Length > 20)
                {
                    MessageBox.Show("Username must be six (6) to twenty (20) characters."
                        , "Invalid Username");
                    txtUsername.Focus();
                }
                else
                {
                    wfLogIn.q = "select pwd, sq,sa from user where uname = '" + txtUsername.Text + "'";
                    wfLogIn.vSelect();
                    if (wfLogIn.t.Rows.Count > 0)
                    {
                        txtUsername.Enabled = false;
                        dbPassword = wfLogIn.t.Rows[0][0].ToString();
                        lbSecQuest.Text = wfLogIn.t.Rows[0][1].ToString();
                        dbSecAns = wfLogIn.t.Rows[0][2].ToString();
                        pnSecurity.Visible = true;
                        txtSecAns.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Username doesn't exist!", "Invalid Input");
                        txtUsername.Focus();
                    }
                }
            }
            else
            {
                if (txtSecAns.Text.Length < 6 || txtSecAns.Text.Length > 20)
                {
                    MessageBox.Show("Security Answer must be six (6) to twenty (20) characters."
                       , "Invalid Security Answer");
                    txtSecAns.Focus();
                }
                else
                {
                    if (txtSecAns.Text.ToUpper() == dbSecAns.ToUpper())
                    {
                        pnUsername.Visible = false;
                        pnPassword.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Your Security Answer didn't match with our records.");
                        txtSecAns.Focus();
                    }
                }
            }
        }
        private void bnUserClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lbShowPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Your Password is (" + dbPassword + ")", "Password Retrieval");
            Close();
        }
        private void bnPassClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bnPassOk_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Length < 6 || txtNewPassword.Text.Length > 20)
            {
                MessageBox.Show("New Password must be six (6) to twenty (20) characters."
                   , "Invalid New Password");
                txtNewPassword.Focus();
            }
            else if (txtConPass.Text.Length < 6 || txtConPass.Text.Length > 20)
            {
                MessageBox.Show("Confirm Password must be six (6) to twenty (20) characters."
                   , "Invalid Confirm Password");
                txtConPass.Focus();
            }
            else
            {
                if (txtNewPassword.Text == txtConPass.Text)
                {
                    wfLogIn.q = "Update user set pwd = '" + txtNewPassword.Text
                        + "' where uname = '" + txtUsername.Text + "'";
                    wfLogIn.vSelect();
                    MessageBox.Show("Your Password has been successfully Change.", "Change Password Complete");
                    Close();
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password didn't match", "Invalid Input");
                    txtNewPassword.Focus();
                }
            }
        }

        private void wfForgotPassword_Load(object sender, EventArgs e)
        {
            Text = "Forgot Password - Form";
        }
    }
}