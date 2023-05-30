using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABLECSIS
{
    public partial class wfCreateUser : Form
    {
        public wfCreateUser()
        {
            InitializeComponent();
        }
        ErrorProvider p = new ErrorProvider();
        public static String sUtype;
        private void bnSave_Click(object sender, EventArgs e)
        {
            p.Clear();
            if (txtUname.Text.Length < 6 || txtUname.Text.Length > 20)
            {
                MessageBox.Show("Username must be six (6) to twenty (20) character."
                    , "Invalid Username");
                txtUname.Focus();
            }
            else if (txtPword.Text.Length < 6 || txtPword.Text.Length > 20)
            {
                MessageBox.Show("Password must be six (6) to twenty (20) characters."
                    , "Invalid Password");
                txtPword.Focus();
            }
            else if (txtConfirm.Text.Length < 6 || txtConfirm.Text.Length > 20)
            {
                MessageBox.Show("Confirm Password must be six (6) to twenty (20) characters."
                    , "Invalid Confirm Password");
                txtConfirm.Focus();
            }
            else if (txtFname.Text.Length < 2 || txtFname.Text.Length > 30)
            {
                MessageBox.Show("Firstname must be two (2) to thrity (30) characters."
                    , "Invalid Firstname");
                txtFname.Focus();
            }
            else if (txtLname.Text.Length < 2 || txtLname.Text.Length > 20)
            {
                MessageBox.Show("Lastname must be two (2) to twenty (20) characters."
                    , "Invalid Lastname");
                txtLname.Focus();
            }
            else if (txtLname.Text.Length < 2 || txtLname.Text.Length > 20)
            {
                MessageBox.Show("Lastname must be two (2) to twenty (20) characters."
                    , "Invalid Lastname");
                txtLname.Focus();
            }
            else if (cbSecQuest.Text == "")
            {
                MessageBox.Show("Please select your security Question."
                    , "Invalid Security Question");
                cbSecQuest.Focus();
            }
            else if (txtSecAns.Text.Length < 6 || txtSecAns.Text.Length > 20)
            {
                MessageBox.Show("Security answer must be six (6) to twenty (20) characters."
                    , "Invalid Security Answer");
                txtSecAns.Focus();
            }
            else
            {
                wfLogIn.q = "Select userid from user where uname = '" + txtUname.Text
                    + "' or (concat(fname,lname) = '" + txtFname.Text + txtLname.Text + "')";
                wfLogIn.vSelect();
                if (wfLogIn.t.Rows.Count == 1)
                {
                    MessageBox.Show("Username or Fullname is already exist.", "Unable to create an account");
                    txtUname.Focus();
                }
                else
                {
                    wfLogIn.q = "select userid from user where uname = '" + txtUname.Text
                        + "' or (fname = '" + txtFname.Text
                        + "' and lname = '" + txtLname.Text + "')";
                    wfLogIn.vSelect();
                    if (wfLogIn.t.Rows.Count > 0)
                    {
                        string sInvalid = "Username or Fullname is already exist.";
                        MessageBox.Show(sInvalid
                            , "Unable to save the following information");
                        txtUname.Focus();
                        p.SetError(txtUname, sInvalid);
                        p.SetError(txtFname, sInvalid);
                        p.SetError(txtLname, sInvalid);
                    }
                    else
                    {
                        if (txtPword.Text == txtConfirm.Text)
                        {
                            wfLogIn.q = "select userid from user where regdate like '"
                               + DateTime.Now.ToString("yyyy") + "%'";
                            wfLogIn.vSelect();
                            string sUserID = "U-" + DateTime.Now.Year + "-" + (Convert.ToInt32
                                (wfLogIn.t.Rows.Count) + 1).ToString("d2");
                            wfLogIn.q = "insert into user values ('" + sUserID
                                + "','" + txtUname.Text
                                + "','" + txtPword.Text
                                + "','" + txtFname.Text
                                + "','" + txtLname.Text
                                + "','" + "Active"
                                + "','" + sUtype
                                + "','" + cbSecQuest.Text
                                + "','" + txtSecAns.Text
                                + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                            wfLogIn.vSelect();
                            MessageBox.Show("Your account has been successfully created."
                                , "Save has been successful");
                            Close();
                        }
                        else
                        {
                            string sInvPass = "Password and Confirm Password didn't match";
                            MessageBox.Show(sInvPass
                                , "Invalid Password and Confirm Password");
                            p.SetError(txtPword, sInvPass);
                            p.SetError(txtConfirm, sInvPass);
                            txtPword.Focus();
                        }
                    }
                }
            }
        }

        private void wfCreateUser_Load(object sender, EventArgs e)
        {
            CancelButton = bnCancel;
            AcceptButton = bnSave;
        }
    }
}