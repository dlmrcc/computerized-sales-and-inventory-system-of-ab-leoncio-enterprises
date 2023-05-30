using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ABLECSIS
{
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
        }


        private void bnSearch_Click(object sender, EventArgs e)
        {
            ucUser_Load(sender, e);
        }
        ToolTip tt = new ToolTip();
        int iCurCell;
        private void bnApply_Click(object sender, EventArgs e)
        {
            iCurCell = dgUser.CurrentCell.RowIndex;
            if (dgUser.Rows[iCurCell].Cells[4].Value.ToString() == "Admin")
            {
                MessageBox.Show("You can't change an admin account", "Invalid Operation");
            }
            else
            {
               if (cbUstatus.Text == "User Status")
                {
                    MessageBox.Show("Please Select User Status", "Invalid User Status");
                    cbUstatus.Focus();
                }
                else
                {
                    wfLogIn.q = "update user set ustatus = '" + cbUstatus.Text
                        + "' where userid = '"
                        + dgUser.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    wfLogIn.vSelect();
                    ucUser_Load(sender, e);
                }
            }
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            wfCreateUser c = new wfCreateUser();
            c.ShowDialog();
            ucUser_Load(sender, e);
            dgUser.SelectedRows[iCurCell].Selected = true;
        }

        private void ucUser_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT userid `USER ID`,"
                + "uname `USERNAME`,"
                + "fname `FIRSTNAME`,"
                + "lname `LASTNAME`,"
                + "utype `USER TYPE`,"
                + "ustatus `USER STATUS` FROM user where "
                + "(userid like '" + txtSearch.Text
                + "%' or uname like '%" + txtSearch.Text
                + "%' or fname like '%" + txtSearch.Text
                + "%' or lname like '%" + txtSearch.Text
                + "%' or ustatus like '%" + txtSearch.Text
                + "%' or utype like '" + txtSearch.Text + "')";
            wfLogIn.vSelect();
            dgUser.DataSource = wfLogIn.t;
            lbResult.Text = dgUser.Rows.Count + " user result(s) has found.";
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
            printDocument1.DocumentName = "List of User";
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
    }
}