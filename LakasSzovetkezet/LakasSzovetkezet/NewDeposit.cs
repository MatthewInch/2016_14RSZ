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
    }
}
