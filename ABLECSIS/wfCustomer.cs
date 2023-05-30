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
    public partial class wfCustomer : Form
    {
        public wfCustomer()
        {
            InitializeComponent();
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfCustomer_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT custid,"
                + " fname,"
                + " lname,"
                + " concat(fname,' ',lname) CUSTOMER,"
                + " comname `COMPANY`,"
                + " connum `CONTACT NUMBER`,"
                + " address `ADDRESS` FROM cust where (concat(fname,' ',lname) like '%" + txtSearch.Text
                + "%' or comname like '" + txtSearch.Text
                + "%' or connum like '" + txtSearch.Text
                + "%' or address like '" + txtSearch.Text + "%') and custid != 1";
            wfLogIn.vSelect();
            dgUser.DataSource = wfLogIn.t;
            lbResult.Text = dgUser.Rows.Count + " customer result has found!";
            dgUser.Columns[0].Visible = false;
            dgUser.Columns[1].Visible = false;
            dgUser.Columns[2].Visible = false;
        }

        private void bnSearch_Click(object sender, EventArgs e)
        {
            wfCustomer_Load(sender, e);
        }
        public static String sSave;
        private void bnAdd_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            vCallCust();
            wfCustomer_Load(sender, e);
        }
        void vCallCust()
        {
            wfCustSet c = new wfCustSet();
            c.ShowDialog();
        }
        private void bnEdit_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            vCallCust();
            wfCustomer_Load(sender, e);
        }
        public static String scustid, sfname, slname, scomname, sconnum, saddress;
        private void dgUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                scustid = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sfname = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[1].Value.ToString();
                slname = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[2].Value.ToString();
                scomname = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[4].Value.ToString();
                sconnum = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[5].Value.ToString();
                saddress = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = print.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
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
            printDocument1.DocumentName = "List of Customer";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgUser, printDocument1, true, true, printDocument1.DocumentName
                , new Font("Tahoma", 18, FontStyle.Bold,
                GraphicsUnit.Point), Color.Black, true);
            return true;
        }

        private void dgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void lbResult_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
