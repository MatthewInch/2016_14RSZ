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
            proxy.StartMessage = "Áron";
            proxy.SetClientMessage = SetTextMessage;
        }
        List<ChatServiceReference.Service1Client> _partnerClients = new List<ChatServiceReference.Service1Client>();
        public void SetTextMessage(string message)
        {
            //txtMessages.Invoke((MethodInvoker)delegate {
            //    txtMessages.Text += message + "\n";
            //}
            //);

            MethodInvoker action = delegate
            {
                txtMessages.Text += String.Format("{0}\r\n", message);
            };
            txtMessages.BeginInvoke(action);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (ChatServiceReference.Service1Client client = new ChatServiceReference.Service1Client())
            {
                //txtText.Text = client.CountALetter(txtText.Text).ToString();
                //txtText.Text = client.GetDefaultMessage();
                //client.send
                foreach (var item in _partnerClients)
                {
                    item.SendMessage(txtText.Text);
                }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChatServiceReference.Service1Client client = new ChatServiceReference.Service1Client(new BasicHttpBinding(),new EndpointAddress("http://192.168.1."+txtAdd.Text+":8733/ChatService/Service1/"));

            string s;
            try
            {              

                try
                {
                    s = client.GetDefaultMessage();
                }
                catch (Exception)
                {

                    throw;
                }
                _partnerClients.Add(client);
                txtMessages.Text += String.Format("{0}\r\n", s);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
