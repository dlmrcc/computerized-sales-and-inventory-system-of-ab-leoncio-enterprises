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
    public partial class wfAddExisting : Form
    {
        public wfAddExisting()
        {
            InitializeComponent();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfAddExisting_Load(object sender, EventArgs e)
        {
            txtQuanArr.Text = "1";
            lbBrand.Text += "  " + wfBeverage.sbrand;
            lbName.Text += "  " + wfBeverage.sname;
            lbNewQty.Text = "New Quantity  " + Convert.ToDouble(Convert.ToDouble(wfBeverage.sqty) + Convert.ToDouble(txtQuanArr.Text)).ToString();
            lbPrice.Text += "  " + wfBeverage.sprice;
            lbQuantity.Text += "  " + wfBeverage.sqty;
        }

        private void txtQuanArr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbNewQty.Text = "New Quantity  " + Convert.ToDouble(Convert.ToDouble(wfBeverage.sqty) + Convert.ToDouble(txtQuanArr.Text)).ToString();
            }
            catch { }
        }
        private void bnAdd_Click(object sender, EventArgs e)
        {
            wfLogIn.q = "insert into invent (inventid, userid, custid, prodid, date, remqty, qtyrec, qtydel, newqty) values (null,'"+wfLogIn.dbuserid
                +"','1','"+wfBeverage.sprodid
                +"','"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                +"','"+wfBeverage.sqty
                +"','"+txtQuanArr.Text
                + "','0','" + Convert.ToDouble(Convert.ToDouble(wfBeverage.sqty)+Convert.ToDouble(txtQuanArr.Text))
                + "')";
            wfLogIn.vSelect();
            wfLogIn.q = "update product set qty = '"+Convert.ToDouble(Convert.ToDouble(wfBeverage.sqty)+Convert.ToDouble(txtQuanArr.Text))
                +"' where prodid = '"+wfBeverage.sprodid+"'";
            wfLogIn.vSelect();
            Close();
        }
    }
}
