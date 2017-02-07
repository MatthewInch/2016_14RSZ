using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTestServicelibrary
{
    public class ChatProxy
    {
        private static readonly ChatProxy _instance = new ChatProxy();

        private ChatProxy()
        {
        }

        public static ChatProxy GetProxy()
        {
            return _instance;
        }

        public Action<string, string> SetClientMessageAction { get; set; }

        public Action<string> GetDefaultMessageAction { get; set; }

        public string StartMessage { get; set; }

        public string GetDefaultMessage(string address)
        {
            if (GetDefaultMessageAction != null)
            {
                GetDefaultMessageAction(address);
            }
            return StartMessage;
        }

        public void GetMessage(string message, string address)
        {
            if (SetClientMessageAction != null)
            {
                SetClientMessageAction(message, address);
            }
        }
    }
}
