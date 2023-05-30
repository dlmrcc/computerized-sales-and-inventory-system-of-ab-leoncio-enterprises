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
    public partial class wfBeverageSet : Form
    {
        public wfBeverageSet()
        {
            InitializeComponent();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            if (wfBeverage.sSave == "Add")
            {
                wfLogIn.q = "SELECT name, brand, unit FROM product p where concat(name, brand, unit) = '" + txtName.Text + cbBrand.Text + cbUnit.Text + "'";
                wfLogIn.vSelect();
                if (wfLogIn.t.Rows.Count == 0)
                {
                    wfLogIn.q = "insert into product (prodid, name, brand, unit, price, qty, lowitem) values (null,'" + txtName.Text
                        + "','" + cbBrand.Text
                        + "','" + cbUnit.Text
                        + "','" + dprice
                        + "','" + txtQty.Text
                        + "','" + txtCrit.Text + "')";
                    wfLogIn.vSelect();
                    wfLogIn.q = "SELECT prodid FROM product order by prodid desc limit 1";
                    wfLogIn.vSelect();
                    wfLogIn.q = "insert into invent (inventid, userid, custid, prodid, date, remqty, qtyrec, qtydel, newqty) values (null,'" + wfLogIn.dbuserid
                        + "','1','" + wfLogIn.t.Rows[0][0]
                        + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        + "','0','" + txtQty.Text
                        + "','0','" + txtQty.Text + "')";
                    wfLogIn.vSelect();
                }
                else
                {
                    MessageBox.Show("The Product is already exist.", "Unable to add product");
                }
            }
            else
            {
                wfLogIn.q = "update product set name = '" + txtName.Text
                    + "', brand = '" + cbBrand.Text
                    + "', unit = '" + cbUnit.Text
                    + "', price = '" + txtprice.Text
                    + "', lowitem = '" + txtCrit.Text
                    + "' where prodid = '" + wfBeverage.sprodid + "'";
                wfLogIn.vSelect();
            }
            Close();
        }

        void vUnit()
        {
            cbUnit.Items.Clear();
            wfLogIn.q = "SELECT distinct unit FROM product order by unit";
            wfLogIn.vSelect();
            for (int a = 0; a < wfLogIn.t.Rows.Count; a++)
                cbUnit.Items.Add(wfLogIn.t.Rows[a][0]);
        }
        private void wfProdSet_Load(object sender, EventArgs e)
        {
            vUnit();
            vBrand();
            if (wfBeverage.sSave == "Edit")
            {
                txtCrit.Text = wfBeverage.slowitem; 
                txtName.Text = wfBeverage.sname;
                txtprice.Text = wfBeverage.sprice;
                cbBrand.Text = wfBeverage.sbrand;
                cbUnit.Text = wfBeverage.sunit;
                txtQty.Text = wfBeverage.sqty;
                txtQty.Enabled = false;
                if (wfLogIn.dbutype != "Admin")
                    txtprice.Enabled = false;
            }
        }
        double dprice;
        void vBrand()
        {
            cbBrand.Items.Clear();
            wfLogIn.q = "SELECT distinct brand FROM product order by brand";
            wfLogIn.vSelect();
            for (int a = 0; a < wfLogIn.t.Rows.Count; a++)
                cbBrand.Items.Add(wfLogIn.t.Rows[a][0]);
        }
        private void txtprice_Leave(object sender, EventArgs e)
        {
            try
            {
                dprice = Convert.ToDouble(txtprice.Text);
            }
            catch { dprice = 0; }
            txtprice.Text = dprice.ToString("n");
        }
    }
}