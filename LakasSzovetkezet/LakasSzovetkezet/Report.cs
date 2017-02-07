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
    public partial class Report : Form
    {
        public class ComboHelper
        {
            public int? Stairway { get; set; }
            public int? Floor { get; set; }
            public int? FlatNumber { get; set; }
            public int FlatID { get; set; }


            public override string ToString()
            {
                return $"{Stairway} lépcsőház - {Floor} em - {FlatNumber}";
            }
        }

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            using (var context = new LakasszovetkezetDbDataContext())
            {
                var items = from item in context.Flats
                            orderby item.Stairway, item.Floor, item.FlatNumber
                            select new ComboHelper() { Stairway = item.Stairway, Floor = item.Floor, FlatNumber = item.FlatNumber, FlatID = item.FlatID };
                cbflat.DataSource = items;
            }
        }

        private void cbflat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFlat = cbflat.SelectedItem as ComboHelper;

            AccessDatabaseWithAction(selectedFlat, (LakasszovetkezetDbDataContext context, Flat flat) => {
                lbOwner.Text = flat.Owner.Name;
                lbResident.Text = flat.Resident.Name;
                panel1.Visible = true;
            });
        }

        private void AccessDatabaseWithAction(ComboHelper selectedFlat, Action<LakasszovetkezetDbDataContext, Flat> currentAction)
        {
            if (selectedFlat != null)
            {
                using (var context = new LakasszovetkezetDbDataContext())
                {
                    var flat = (from f in context.Flats
                                where f.FlatID == selectedFlat.FlatID
                                select f).FirstOrDefault();
                    currentAction(context, flat);
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            using (var context = new LakasszovetkezetDbDataContext())
            {
                
            }
        }
    }
}
