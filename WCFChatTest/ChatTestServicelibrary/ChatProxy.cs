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

        public Action<string> SetClientMessage;

        public string StartMessage { get; set; }

        public void GetMessage(string message)
        {
            if (SetClientMessage != null)
            {
                SetClientMessage(message);
            }
        }
    }
}
