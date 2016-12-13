using ChatTestServicelibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatTest
{
    public partial class Form1 : Form
    {
        private ServiceHost _host;

        public Form1()
        {
            InitializeComponent();
            ChatProxy proxy = ChatProxy.GetProxy();
            proxy.StartMessage = "ez az alapszöveg";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (ChatServiceReference.Service1Client client = new ChatServiceReference.Service1Client())
            {
                //txtText.Text = client.CountALetter(txtText.Text).ToString();
                txtText.Text = client.GetDefaultMessage();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                _host = new ServiceHost(typeof(ChatTestServicelibrary.Service1));
                _host.Open();
            });
        }
    }
}
