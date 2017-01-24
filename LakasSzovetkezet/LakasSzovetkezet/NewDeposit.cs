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
    public partial class NewDeposit : Form
    {
        private int _currentPrice = 0;

        public class ComboHelper
        {
            public string Stairway { get; set; }
            public int? Floor { get; set; }
            public int? FlatNumber { get; set; }
            public int FlatID { get; set; }


            public override string ToString()
            {
                return $"{Stairway} lépcsőház - {Floor} em - {FlatNumber}";
            }
        }
        public NewDeposit()
        {
            InitializeComponent();
        }

        private void NewDeposit_Load(object sender, EventArgs e)
        {
            using (var context = new LakasszovetkezetDbDataContext())
            {
                var items = from item in context.Flats
                            orderby item.Stairway, item.Floor, item.FlatNumber
                            select new ComboHelper() { Stairway = item.Stairway, Floor = item.Floor, FlatNumber = item.FlatNumber, FlatID = item.FlatID };
                cbFlat.DataSource = items;
            }
        }

        private void cbFlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFlat = cbFlat.SelectedItem as ComboHelper;
            if (selectedFlat != null)
            {
                using (var context = new LakasszovetkezetDbDataContext())
                {
                    var flat = (from f in context.Flats
                               where f.FlatID == selectedFlat.FlatID
                               select new { OwnerName = f.Owner.Name, ResidentName = f.Resident.Name, Size=f.Size, Radiators=f.Radiators }).FirstOrDefault();
                    lbOwner.Text = flat.OwnerName;
                    lbResident.Text = flat.ResidentName;
                    panel1.Visible = true;

                    var deposits = from d in context.Deposits
                                   where d.FlatID == selectedFlat.FlatID
                                   select d;

                    #region Generate month checkboxes
                    flowLayoutPanel1.Controls.Clear();
                    for (int i=1;i<=12;i++)
                    {
                        var month = new CheckBox();
                        month.CheckedChanged += Month_CheckedChanged;

                        var isPayed = deposits.Count(d => d.Month == i) > 0;
                        month.Enabled = !isPayed;
                        month.Checked = isPayed;

                        month.Text = (new DateTime(2016, i, 1)).ToString("MMMM");
                        flowLayoutPanel1.Controls.Add(month);
                    }
                    #endregion

                    _currentPrice = ValueHelper.CalculateValue(flat.Size ?? 0, flat.Radiators ?? 0);



                }
            }
        }


        private void Month_CheckedChanged(object sender, EventArgs e)
        {
            int month = 1;
            int sumPrice = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                var checkbox = control as CheckBox;
                if (checkbox != null)
                {
                    if (checkbox.Enabled && checkbox.Checked)
                    {
                        sumPrice += _currentPrice;
                    }
                    month++;
                }
                
            }
            txtSumPrice.Text = sumPrice.ToString();
        }
    }
}
