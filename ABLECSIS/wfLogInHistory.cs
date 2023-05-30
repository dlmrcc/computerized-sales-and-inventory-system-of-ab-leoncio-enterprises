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
    public partial class wfLogInHistory : Form
    {
        public wfLogInHistory()
        {
            InitializeComponent();
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfLogInHistory_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT logid `LOG ID`,"//0
                + " concat('[',u.utype,'] ',u.fname,' ',u.lname) `USER`,"//1
                + " login `LOG IN`,"//2
                + " logout `LOG OUT` FROM loghis l left join `user` u"//3
                + " on (u.userid = l.userid) where login between '" + dtFrom.Value.ToString("yyyy-MM-dd 00:00:00")
                + "' and '" + dtTo.Value.ToString("yyyy-MM-dd 23:59:59") + "'";
            wfLogIn.vSelect();
            dgUser.DataSource = wfLogIn.t;
            dgUser.Columns[2].DefaultCellStyle.Format = "MMM. dd, yyyy hh:mm:ss tt";
            dgUser.Columns[3].DefaultCellStyle.Format = "MMM. dd, yyyy hh:mm:ss tt";
            lbResult.Text = dgUser.Rows.Count + " Log History has been found!";
        }

        private void bnSearch_Click(object sender, EventArgs e)
        {
            wfLogInHistory_Load(sender, e);
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
            printDocument1.DocumentName = "Log - In History";
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
