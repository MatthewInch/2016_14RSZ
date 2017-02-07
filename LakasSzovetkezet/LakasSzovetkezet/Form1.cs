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
        
        private void btReport_Click(object sender, EventArgs e)
        {
            using (var context = new LakasszovetkezetDbDataContext())
            {
                 var items = from item in context.Deposits
                            select new { DepositID = item.DepositID, DepositDate = item.DepositDate, DepositType = item.DepositType, FlatID = item.FlatID,Year=item.Year,Month=item.Month,Value=item.Value,Stairway=item.Flat.Stairway,};
                foreach (var item in items)
                {
                    Console.WriteLine(item.DepositID+";"+);
                }
            }
            
           
        }
       
    }
}
