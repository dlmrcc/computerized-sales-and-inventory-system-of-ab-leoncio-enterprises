using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace ABLECSIS
{
    public partial class wfHome : Form
    {
        public wfHome()
        {
            InitializeComponent();
        }
        private void dgCritical_DoubleClick(object sender, EventArgs e)
        {
            wfBeverage.sprodid = dgCritical.Rows[dgCritical.CurrentCell.RowIndex].Cells[0].Value.ToString();
            wfBeverage.sname = dgCritical.Rows[dgCritical.CurrentCell.RowIndex].Cells[1].Value.ToString();
            wfBeverage.sbrand = dgCritical.Rows[dgCritical.CurrentCell.RowIndex].Cells[2].Value.ToString();
            wfBeverage.sunit = dgCritical.Rows[dgCritical.CurrentCell.RowIndex].Cells[3].Value.ToString();
            wfBeverage.sprice = dgCritical.Rows[dgCritical.CurrentCell.RowIndex].Cells[4].Value.ToString();
            wfBeverage.sqty = dgCritical.Rows[dgCritical.CurrentCell.RowIndex].Cells[5].Value.ToString();
            wfBeverage.slowitem = dgCritical.Rows[dgCritical.CurrentCell.RowIndex].Cells[6].Value.ToString();
            wfAddExisting a = new wfAddExisting();
            a.ShowDialog();
            vCriticalItem();
        }
        void vCriticalItem()
        {
            wfLogIn.q = "SELECT prodid,"//0
                +" name `NAME`,"//1
                +" brand `BRAND`,"//2
                +" unit `UNIT`,"//3
                +" price `PRICE`,"//4
                +" qty `QTY`,"//5
                +" lowitem `LOW ITEM`"//6
                +" FROM product where lowitem >= qty";
            wfLogIn.vSelect();
            dgCritical.DataSource = wfLogIn.t;
            dgCritical.Columns[0].Visible = false;
            dgCritical.Columns[1].HeaderText = "Product Name";
            dgCritical.Columns[4].DefaultCellStyle.Format = "c";
            dgCritical.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            if (dgCritical.Rows.Count == 0)
            {
                vCrit();
                MessageBox.Show("None critical item has been found."
                    , "Critical Item is clear"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
        }
        private void wfHome_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture
                = new System.Globalization.CultureInfo("en-ph");
            wfLogIn l = new wfLogIn();
            l.ShowDialog();
            tmDate.Enabled = false;
            if (wfLogIn.bExit == true)
                Close();
            else
            {
                vCallNameDate(sender, e);
                pnCriticalItem.Visible = true;
                vCriticalItem();
            }
            tmDate.Enabled = !false;
        }
        void vCallNameDate(object sender, EventArgs e)
        {
            lbUser.Text = wfLogIn.dbutype + ": " + wfLogIn.dbfname + " " + wfLogIn.dblname
                + " [" + wfLogIn.dbuserid + "]";
            tmDate_Tick(sender, e);
        }
        private void tmDate_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dddd MMMM dd, yyyy hh:mm:ss tt");
        }

        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfChangeUser c = new wfChangeUser();
            c.ShowDialog();
            vCallNameDate(sender, e);
        }

        private void wfHome_Resize(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wfLogIn.bExit != true)
            {
                if (MessageBox.Show("Do you want to Log - Out?"
                    , "Confirm Log - Out"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    foreach (Form childForm in MdiChildren)
                        childForm.Close();
                    wfLogIn.q = "update loghis set logout = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        + "' where userid = '" + wfLogIn.dbuserid
                        + "' and login = '" + wfLogIn.dLogIn + "'";
                    wfLogIn.vSelect();
                    lbDate.Text = "";
                    lbUser.Text = "";
                    tmDate.Enabled = false;
                    wfHome_Load(sender, e);
                    e.Cancel = true;
                }
            }
        }

        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.dbutype == "Admin")
            {
                wfUser c = new wfUser();
                c.MdiParent = this;
                c.WindowState = FormWindowState.Maximized;
                c.Show();
            }
            else
            {
                MessageBox.Show("You can't access this form."
                    , "Access Forbidden"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Stop);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnProduct_Click(object sender, EventArgs e)
        {
            wfBeverage p = new wfBeverage();
            p.MdiParent = this;
            p.WindowState = FormWindowState.Maximized;
            p.Show();
        }

        private void cbCustomer_Click(object sender, EventArgs e)
        {
            wfCustomer c = new wfCustomer();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.dbutype == "Admin")
            {
                wfInventory i = new wfInventory();
            i.MdiParent = this;
            i.WindowState = FormWindowState.Maximized;
            i.Show();
            }
            else
            {
                MessageBox.Show("You can't access this form."
                    , "Access Forbidden"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Stop);
            }
            
        }

        private void logInHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.dbutype == "Admin")
            {
                wfLogInHistory h = new wfLogInHistory();
                h.MdiParent = this;
                h.WindowState = FormWindowState.Maximized;
                h.Show();
            }
            else
            {
                MessageBox.Show("You can't access this form."
                    , "Access Forbidden"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Stop);
            }
           
        }

        private void bnPurchasing_Click(object sender, EventArgs e)
        {
            wfPurchasing p = new wfPurchasing();
            p.MdiParent = this;
            p.WindowState = FormWindowState.Maximized;
            p.Show();
        }
        void vCrit()
        {
            if (bnCritical.Checked == true)
            {
                pnCriticalItem.Visible = !true;
                bnCritical.Checked = false;
            }
            else
            {
                pnCriticalItem.Visible = true;
                bnCritical.Checked = !false;
            }
        }
        private void bnCritical_Click(object sender, EventArgs e)
        {
            vCriticalItem();
            vCrit();
        }

        private void bnPrint_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = printDocument1;
                MyPrintPreviewDialog.ShowDialog();
                printDocument1.Print();
            }
        }
        Printing print;
        private bool SetupThePrinting()//==================
        {
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;
            printDocument1.DocumentName = "Critical Items";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgCritical, printDocument1, true, true, printDocument1.DocumentName
                , new Font("Tahoma", 18, FontStyle.Bold,
                GraphicsUnit.Point), Color.Black, true);
            return true;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = print.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }       
    }
}