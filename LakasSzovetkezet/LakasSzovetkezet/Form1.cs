using Novacode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakasSzovetkezet
{
    public partial class Form1 : Form
    {
        private LakasszovetkezetDbDataContext _context = new LakasszovetkezetDbDataContext();
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
            flatBindingSource.DataSource = _context.Flats;
            
        }

        private void flatBindingNavigator_RendererChanged(object sender, EventArgs e)
        {

        }

        private void flatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var flat = flatBindingSource.Current as Flat;
            if (flat != null)
            {
                var updatedFlat = (from f in _context.Flats
                                   where f.FlatID == flat.FlatID
                                   select f).First();
                updatedFlat.Size = flat.Size;

                _context.SubmitChanges();
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
        }

        private void flatBindingSource_PositionChanged(object sender, EventArgs e)
        {

        }

        private void flatBindingSource_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DocX document = DocX.Load("Template.docx"))
            {
                document.ReplaceText("{Csomag.Description}", "Ez a csomag leírása.");
                document.ReplaceText("{Csomag.Price}", "Ez a csomag ára.");
                document.SaveAs("Test.docx");

                using (PrintDialog dialog = new PrintDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {

                            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("Test.docx");
                            info.Arguments = "\"" + dialog.PrinterSettings.PrinterName + "\"";
                            info.CreateNoWindow = true;
                            info.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            info.UseShellExecute = true;
                            info.Verb = "PrintTo";
                            System.Diagnostics.Process.Start(info);
                        } // end try
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message + "\n\n Unable to print the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } // end catch
                    }
                }

            }
        }
    }
}
