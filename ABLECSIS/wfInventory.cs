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
    public partial class wfInventory : Form
    {
        public wfInventory()
        {
            InitializeComponent();
        }

        private void wfInventory_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT inventid,"
               + " `DATE`,"
               + " concat(u.fname,' ',u.lname) `USER`,"
               + " concat(c.fname,' ',c.lname) `CUSTOMER`,"
               + " concat(p.brand,' ',p.name,' (',p.unit,')') `PRODUCT`,"
               + " remqty `REMAINING QTY`,"
               + " qtyrec `QTY RECEIVED`,"
               + " qtydel `QTY DELIVER`,"
               + " newqty `NEW QTY`"
               + " FROM invent i left join (`user` u,cust c, product p)"
               + " on (i.userid = u.userid and c.custid = i.custid and p.prodid = i.prodid)";
            wfLogIn.vSelect();
            dgUser.DataSource = wfLogIn.t;
            dgUser.Columns[0].Visible = false;
            dgUser.Columns[1].DefaultCellStyle.Format = "MMM. dd, yyyy hh:mm:ss tt";
            for (int a = 0; a < dgUser.Columns.Count; a++)
                dgUser.Columns[a].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            printDocument1.DocumentName = "Inventory";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgUser, printDocument1, true, true, printDocument1.DocumentName
                , new Font("Tahoma", 18, FontStyle.Bold,
                GraphicsUnit.Point), Color.Black, true);
            return true;
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

        private void bnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
