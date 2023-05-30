using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABLECSIS
{
    public partial class wfAdminPassword : Form
    {
        public wfAdminPassword()
        {
            InitializeComponent();
        }
        string sPassword;
        private void wfAdminPassword_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "select pwd from `user` where utype = 'Admin'";
            wfLogIn.vSelect();
            sPassword = wfLogIn.t.Rows[0][0].ToString();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            bPwdOk = false;
            Close();
        }
        public static Boolean bPwdOk;
        private void bnSave_Click(object sender, EventArgs e)
        {
            if (sPassword == txtCurrentPassword.Text)
            {
                bPwdOk = true;
                Close();
            }
            else
            {
                bPwdOk = false;
                Close();
            }
        }
    }
}
