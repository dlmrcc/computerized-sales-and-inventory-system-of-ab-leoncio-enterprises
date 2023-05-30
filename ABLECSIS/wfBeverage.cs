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
    public partial class wfBeverage : Form
    {
        public wfBeverage()
        {
            InitializeComponent();
        }
        public static String sprodid, sname, sbrand, sunit, sprice, sqty, slowitem;
        private void dgUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sprodid = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sbrand = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[1].Value.ToString();
                sname = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[2].Value.ToString();
                sunit = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[3].Value.ToString();
                sprice = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[4].Value.ToString();
                sqty = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[5].Value.ToString();
                slowitem = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }
        public static String sSave;
        private void bnSearch_Click(object sender, EventArgs e)
        {
            wfProduct_Load(sender, e);
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            vCallProd();
            wfProduct_Load(sender, e);
        }
        void vCallProd()
        {
            wfBeverageSet p = new wfBeverageSet();
            p.ShowDialog();
        }
        private void bnAdd_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            vCallProd();
            wfProduct_Load(sender, e);
        }
        private void bnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnAddExisting_Click(object sender, EventArgs e)
        {
            wfAddExisting a = new wfAddExisting();
            a.ShowDialog();
            wfProduct_Load(sender, e);
        }

        private void wfProduct_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-ph");
            wfLogIn.q = "SELECT prodid,"//
                + " brand BRAND,"//2
                + " name NAME,"//1
                + " unit UNIT,"//3
                + " price PRICE,"//4
                + " qty `QUANTITY`,"//5
                + " lowitem `CRITICAL ITEM` FROM product where (prodid like '" + txtSearch.Text
                + "%' or name like '" + txtSearch.Text
                + "%' or brand like '" + txtSearch.Text
                + "%' or unit like '" + txtSearch.Text
                + "%' or price between '" + txtSearch.Text + "' and '0')";
            wfLogIn.vSelect();
            dgUser.DataSource = wfLogIn.t;
            for (int a = 0; a < dgUser.Rows.Count; a++)
            {
                if (Convert.ToDouble(dgUser.Rows[a].Cells[5].Value) <= Convert.ToDouble(dgUser.Rows[a].Cells[6].Value))
                    dgUser.Rows[a].DefaultCellStyle.BackColor = Color.Yellow;
            }
            lbResult.Text = dgUser.Rows.Count + " product has been found!";
            dgUser.Columns[0].Visible = false;
            dgUser.Columns[4].DefaultCellStyle.Format = "c";
            dgUser.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            printDocument1.DocumentName = "List of Product";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgUser, printDocument1, true, true, printDocument1.DocumentName
                , new Font("Tahoma", 18, FontStyle.Bold,
                GraphicsUnit.Point), Color.Black, true);
            return true;
        }
    }
}
