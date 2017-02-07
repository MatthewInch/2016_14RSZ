using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakasSzovetkezet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewDeposit_Click(object sender, EventArgs e)
        {
            var newDepositForm = new NewDeposit();
            newDepositForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var ReportForm = new Report();
            ReportForm.Show();
        }
    }
}
