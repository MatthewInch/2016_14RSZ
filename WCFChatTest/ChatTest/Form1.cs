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
        private List<ChatServiceReference.Service1Client> _PartnerClients = new List<ChatServiceReference.Service1Client>();
        private Dictionary<string, string> _partnersName = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            ChatProxy proxy = ChatProxy.GetProxy();
            proxy.StartMessage = "Szőke Mátyás";
            proxy.SetClientMessageAction = SetTextMessage;
            proxy.GetDefaultMessageAction = GetDefaultMessage;
        }

        private void GetDefaultMessage(string address)
        {
            if (_partnersName.ContainsKey(address))
            {
                MethodInvoker action = delegate
                {
                    txtMessages.Text += $"{_partnersName[address]} is in the clients list again.\r\n";
                };
                txtMessages.BeginInvoke(action);
            }
            else
            {
                AddClient(address);
                MethodInvoker action = delegate
                {
                    txtMessages.Text += $"New client: {address}\r\n";
                };
                txtMessages.BeginInvoke(action);
            }
        }

        public void SetTextMessage(string message,string address)
        {
            string name = address;
            if (_partnersName.ContainsKey(address))
            {
                name = _partnersName[address];
            }
            MethodInvoker action = delegate
            {
                txtMessages.Text += $"{name}: {message}\r\n";
            };
            txtMessages.BeginInvoke(action);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (var client in _PartnerClients)
            {
                client.SendMessage(txtText.Text);
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

        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            AddClient(textBox1.Text);
        }

        private void AddClient(string address)
        {
            try
            {
                var myBinding = new BasicHttpBinding();
                var myEndpointAddress = new EndpointAddress($"http://{address}:8733/ChatService/Service1/");

                ChatServiceReference.Service1Client client = new ChatServiceReference.Service1Client(myBinding, myEndpointAddress);
                try
                {
                    if (_partnersName.ContainsKey(address))
                    { }
                    else
                    {
                        _partnersName.Add(address, address);
                        var name = client.GetDefaultMessage();
                        _partnersName[address] = name;
                        _PartnerClients.Add(client);
                        txtPartners.Text += $"Partner: {name} hozzáadva.\n";
                    }
                }
                catch (Exception getEx)
                {
                    txtPartners.Text += $"Error: {getEx.Message}\n";
                }

            }
            catch (Exception ex)
            {
                txtPartners.Text += $"Error: {ex.Message}\n";
            }
        }
    }
}
