using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeTypes();
        }

        public static Int64 balance = 0;
        public static List<string> types = new List<string>();

        public void InitializeTypes()
        {
            // types.Add("Tiền nhà");
            // types.Add("Tiền ăn");
            // types.Add("Tiền học");
        }

        private void cmdAddExpense_Click(object sender, EventArgs e)
        {
            FormAddExpense fae = new FormAddExpense();
            fae.ShowDialog();
        }

        private void cmdAddIncome_Click(object sender, EventArgs e)
        {
            FormAddIncome fai = new FormAddIncome();
            fai.ShowDialog();
        }

        private void cmdAddType_Click(object sender, EventArgs e)
        {
            FormAddType fat = new FormAddType();
            fat.ShowDialog();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExpenseHistory fh = new FormExpenseHistory();
            fh.ShowDialog();
        }
    }
}
