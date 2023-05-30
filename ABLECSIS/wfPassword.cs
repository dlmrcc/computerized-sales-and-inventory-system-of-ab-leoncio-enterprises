using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABLECSIS
{
    public partial class wfPassword : Form
    {
        public wfPassword()
        {
            InitializeComponent();
        }
        public static String sCurrentPassword;
        private void bnSave_Click(object sender, EventArgs e)
        {
            sCurrentPassword = txtCurrentPassword.Text;
            Close();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            sCurrentPassword = "";
            Close();
        }

        private void wfPassword_Load(object sender, EventArgs e)
        {

        }
    }
}