using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
namespace ABLECSIS
{
    public partial class wfPurchasing : Form
    {
        public wfPurchasing()
        {
            InitializeComponent();
        }
        void vBeverage()
        {
            wfLogIn.q = "SELECT prodid,"//0
                + " concat(brand, ' ',name) `BEVERAGE`,"//1
                + " unit `UNIT`,"//2
                + " price `PRICE`,"//3
                + " qty `QUANTITY`"//4
                + " FROM product where (concat(brand, ' ',name) like '" + txtSearchBeverage.Text
                + "%' or unit like '" + txtSearchBeverage.Text
                + "%')";
            wfLogIn.vSelect();
            dgBeverage.DataSource = wfLogIn.t;
            dgBeverage.Columns[0].Visible = false;
            dgBeverage.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgBeverage.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgBeverage.Columns[3].DefaultCellStyle.Format = "c";
            lbBeverageResult.Text = dgBeverage.Rows.Count + " beverage result has found!";
        }
        private void wfPurchasing_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-ph");
            vCustomer();
            vBeverage();
            vBillingID();
            vPurchase();
        }
        void vCustomer()
        {
            wfLogIn.q = "SELECT custid,"//0
                + " concat(fname,' ',lname) `CUSTOMER`,"//1
                + " comname `CAMPANY NAME`,"//2
                + " connum,"//3
                + " ADDRESS"//4
                + " FROM cust where custid != '1'"
                + " and (concat(fname,' ',lname) like '" + txtSearchCustomer.Text
                + "%' or comname like '" + txtSearchCustomer.Text
                + "%' or address like '" + txtSearchCustomer.Text
                + "%')";
            wfLogIn.vSelect();
            dgCustomer.DataSource = wfLogIn.t;
            dgCustomer.Columns[0].Visible = false;
            dgCustomer.Columns[2].Visible = false;
            dgCustomer.Columns[3].Visible = false;
            dgCustomer.Columns[4].Visible = false;
            lbResultCustomer.Text = dgCustomer.Rows.Count + " customer result has found!";
            if (dgCustomer.Rows.Count == 0)
            {
                lbCompName.Text = "Null";
                lbConNo.Text = "Null";
                rtAddress.Text = "Null";
            }
        }
        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            vCustomer();
        }
        String scustid;
        private void dgCustomer_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                scustid = dgCustomer.Rows[dgCustomer.CurrentCell.RowIndex].Cells[0].Value.ToString();
                lbCompName.Text = dgCustomer.Rows[dgCustomer.CurrentCell.RowIndex].Cells[2].Value.ToString();
                lbConNo.Text = dgCustomer.Rows[dgCustomer.CurrentCell.RowIndex].Cells[3].Value.ToString();
                rtAddress.Text = dgCustomer.Rows[dgCustomer.CurrentCell.RowIndex].Cells[4].Value.ToString();
                vPurchase();
            }
            catch { }
        }

        private void txtSearchBeverage_TextChanged(object sender, EventArgs e)
        {
            vBeverage();
        }

        private void bnAddCustomer_Click(object sender, EventArgs e)
        {
            wfCustomer.sSave = "Add";
            wfCustSet c = new wfCustSet();
            c.ShowDialog();
            vCustomer();
        }

        private void bnAddBeverage_Click(object sender, EventArgs e)
        {
            wfBeverage.sSave = "Add";
            wfBeverageSet s = new wfBeverageSet();
            s.ShowDialog();
            vBeverage();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        string sBillingID;
        void vBillingID()
        {
            wfLogIn.q = "select billingid from billing where custid = '" + scustid
                   + "' and flag = '" + "Unpaid" + "'";
            wfLogIn.vSelect();
            try
            {
                sBillingID = wfLogIn.t.Rows[0][0].ToString();
            }
            catch { sBillingID = ""; }
        }
        void vPurchase()
        {
            wfLogIn.q = "SELECT subid,"//0
                + " concat(p.brand,' ', p.name) `BEVERAGE`,"//1
                + " p.UNIT,"//2
                + " s.qty `QUANTITY`,"//3
                + " s.`PRICE`,"//4
                + " s.`AMOUNT`,"//5
                + " s.`prodid`"//6
                + " FROM sub s left join"
                + " (product p, billing b, cust c, `user` u) on"
                + " (s.billingid = b.billingid and s.prodid = p.prodid"
                + " and c.custid = b.custid and b.userid = u.userid) where b.custid = '"
                + scustid + "' and b.flag = '" + "Unpaid" + "'";
            wfLogIn.vSelect();
            dgPurchase.DataSource = wfLogIn.t;
            dgPurchase.Columns[0].Visible = false;
            dgPurchase.Columns[6].Visible = false;
            dgPurchase.Columns[4].DefaultCellStyle.Format = "c";
            dgPurchase.Columns[5].DefaultCellStyle.Format = "c";
            dgPurchase.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgPurchase.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            lbResultPurchase.Text = dgPurchase.Rows.Count + " beverage result has found!";
            vTotalOrder();
        }
        double dTotalQty;
        double dTotalAmount;
        void vTotalOrder()
        {
            wfLogIn.q = "SELECT sum(s.qty),"
                + " sum(s.amount)"
                + " FROM sub s left join (billing b, cust c) on"
                + " (s.billingid = b.billingid and c.custid = b.custid)"
                + " where b.custid = '" + scustid
                + "' and b.flag = 'Unpaid'";
            wfLogIn.vSelect();
            if (dgPurchase.Rows.Count > 0)
            {
                dTotalQty = Convert.ToDouble(wfLogIn.t.Rows[0][0]);
                dTotalAmount = Convert.ToDouble(wfLogIn.t.Rows[0][1]);
            }
            else
            {
                dTotalQty = 0;
                dTotalAmount = 0;
            }
            lbTotalItem.Text = dTotalQty.ToString();
            lbTotalAmount.Text = dTotalAmount.ToString("c");
            vCash();
        }
        private void bnPurchase_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgBeverage.Rows[dgBeverage.CurrentCell.RowIndex].Cells[4].Value) >= Convert.ToInt32(txtQuantity.Text))
            {
                int iCounter = 0;
                for (int a = 0; a < dgPurchase.Rows.Count; a++)
                {
                    if (dgBeverage.Rows[dgBeverage.CurrentCell.RowIndex].Cells[1].Value.ToString()
                        + dgBeverage.Rows[dgBeverage.CurrentCell.RowIndex].Cells[2].Value.ToString() ==
                        dgPurchase.Rows[a].Cells[1].Value.ToString()
                        + dgPurchase.Rows[a].Cells[2].Value.ToString())
                    {
                        iCounter++;
                        break;
                    }
                }

                if (iCounter == 0)
                {
                    if (dgPurchase.Rows.Count == 0)
                    {
                        wfLogIn.q = "insert into billing (billingid, userid, custid, date, flag)"
                            + " values (null,'" + wfLogIn.dbuserid
                            + "','" + scustid
                            + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                            + "','" + "Unpaid" + "')";
                        wfLogIn.vSelect();
                    }
                    vBillingID();
                    wfLogIn.q = "insert into sub"
                        + " (subid, billingid, prodid, qty, price, amount)"
                        + " values (null,'" + sBillingID
                        + "','" + sProdID
                        + "','" + txtQuantity.Text
                        + "','" + dPrice
                        + "','" + (dPrice * Convert.ToDouble(txtQuantity.Text)) + "')";
                    wfLogIn.vSelect();
                    wfLogIn.q = "insert into invent"
                        + " (inventid, userid, custid, prodid, date, remqty, qtyrec, qtydel, newqty)"
                        + " values (null,'" + wfLogIn.dbuserid
                        + "','" + scustid
                        + "','" + sProdID
                        + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        + "','" + dQty
                        + "','" + 0
                        + "','" + txtQuantity.Text
                        + "','" + (dQty - Convert.ToDouble(txtQuantity.Text)) + "')";
                    wfLogIn.vSelect();
                    wfLogIn.q = "update product set qty = '" + (dQty - Convert.ToDouble(txtQuantity.Text))
                        + "' where prodid = '" + sProdID + "'";
                    wfLogIn.vSelect();
                    vBeverage();
                    vPurchase();
                    txtQuantity.Text = "1";
                }
                else
                {
                    MessageBox.Show("The customer has already bought "
                        + dgBeverage.Rows[dgBeverage.CurrentCell.RowIndex].Cells[1].Value.ToString()
                        + " " + dgBeverage.Rows[dgBeverage.CurrentCell.RowIndex].Cells[2].Value.ToString()
                        , "Unable to buy a same product");
                }
            }
            else
            {
                MessageBox.Show("Purchase quantity must not be greater than " + dgBeverage.Rows[dgBeverage.CurrentCell.RowIndex].Cells[4].Value, "Invalid Purchase Quantity");
                txtQuantity.Focus();
            }
        }
        String sProdID;
        Double dPrice, dQty;
        private void dgBeverage_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sProdID = dgBeverage.Rows[dgBeverage.CurrentCell.RowIndex].Cells[0].Value.ToString();
                dPrice = Convert.ToDouble(dgBeverage.Rows[dgBeverage.CurrentCell.RowIndex].Cells[3].Value);
                lbPrice.Text = dPrice.ToString("c");
                dQty = Convert.ToDouble(dgBeverage.Rows[dgBeverage.CurrentCell.RowIndex].Cells[4].Value);
                txtQuantity_TextChanged(sender, e);
            }
            catch { }
        }
        Double dTotal;
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dTotal = dPrice * Convert.ToDouble(txtQuantity.Text);
            }
            catch { dTotal = 0; }
            lbTotal.Text = dTotal.ToString("c");
        }

        private void bnVoid_Click(object sender, EventArgs e)
        {
            if (wfLogIn.dbutype == "Admin")
            {
                wfAdminPassword.bPwdOk = true;
            }
            else
            {
                wfAdminPassword p = new wfAdminPassword();
                p.ShowDialog();
            }
            if (wfAdminPassword.bPwdOk == true)
            {
                if (dgPurchase.Rows.Count != 0)
                {
                    wfLogIn.q = "select qty from product where prodid = '"
                             + dgPurchase.Rows[dgPurchase.CurrentCell.RowIndex].Cells[6].Value + "'";
                    wfLogIn.vSelect();
                    double qty = Convert.ToDouble(wfLogIn.t.Rows[0][0]);
                    wfLogIn.q = "update product set qty = '"
                        + (qty + Convert.ToDouble(dgPurchase.Rows[dgPurchase.CurrentCell.RowIndex].Cells[3].Value))
                        + "' where prodid = '" + dgPurchase.Rows[dgPurchase.CurrentCell.RowIndex].Cells[6].Value + "'";
                    wfLogIn.vSelect();
                    wfLogIn.q = "insert into invent"
                        + " (inventid, userid, custid, prodid, date, remqty, qtyrec, qtydel, newqty)"
                        + " values (null,'" + wfLogIn.dbuserid
                        + "','" + scustid
                        + "','" + dgPurchase.Rows[dgPurchase.CurrentCell.RowIndex].Cells[6].Value
                        + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        + "','" + qty
                        + "','" + dgPurchase.Rows[dgPurchase.CurrentCell.RowIndex].Cells[3].Value
                        + "','" + 0
                        + "','" + (Convert.ToDouble(dgPurchase.Rows[dgPurchase.CurrentCell.RowIndex].Cells[3].Value) + qty)
                        + "')";
                    wfLogIn.vSelect();
                    wfLogIn.q = "delete from sub where subid = '" + dgPurchase.Rows[dgPurchase.CurrentCell.RowIndex].Cells[0].Value
                        + "'";
                    wfLogIn.vSelect();
                    vBeverage();
                    vPurchase();
                }
                else
                {
                    MessageBox.Show("You can't void a null order", "Invalid Void");
                }
            }
            else
            {
                MessageBox.Show("Unable to void. Please Contact your Administrator.", "Prohibited Action");
            }
        }
        double dCash;
        double dBalance;
        double dChange;
        void vCash()
        {
            try
            {
                dCash = double.Parse(txtCash.Text);
                if (dTotalAmount > dCash)
                {
                    dBalance = dTotalAmount - dCash;
                    dChange = 0;
                }
                else
                {
                    dBalance = 0;
                    dChange = dCash - dTotalAmount;
                }
            }
            catch
            {
                dBalance = dTotalAmount;
                dChange = 0;
            }
            lbBalance.Text = dBalance.ToString("c");
            lbChange.Text = dChange.ToString("c");
        }
        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            vCash();  
        }
    }
}