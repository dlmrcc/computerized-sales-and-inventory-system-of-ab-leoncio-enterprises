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
    public partial class wfCustSet : Form
    {
        public wfCustSet()
        {
            InitializeComponent();
        }

        private void wfCustSet_Load(object sender, EventArgs e)
        {
            if (wfCustomer.sSave == "Edit")
            {
                txtAddress.Text = wfCustomer.saddress;
                txtCompany.Text = wfCustomer.scomname;
                txtContactNumber.Text = wfCustomer.sconnum;
                txtFname.Text = wfCustomer.sfname;
                txtLname.Text = wfCustomer.slname;
            }
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            if (wfCustomer.sSave == "Add")
            {
                wfLogIn.q = "insert into cust (custid, fname, lname, comname, connum, address) values (null,'" + txtFname.Text
                    + "','" + txtLname.Text
                    + "','" + txtCompany.Text
                    + "','" + txtContactNumber.Text
                    + "','" + txtAddress.Text + "')";
            }
            else
            {
                wfLogIn.q = "update cust set fname = '"+txtFname.Text
                    +"', lname = '"+txtLname.Text
                    +"', comname = '"+txtCompany.Text
                    +"', connum = '"+txtContactNumber.Text
                    +"', address = '"+txtAddress.Text
                    +"' where custid = '"+wfCustomer.scustid+"'";
            }
            wfLogIn.vSelect();
            Close();
        }
    }
}
