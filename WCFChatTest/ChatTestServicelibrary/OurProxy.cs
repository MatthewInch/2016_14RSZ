﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTestServicelibrary
{
    public class OurProxy
    {
        private static readonly OurProxy _instance = new OurProxy();

        private OurProxy()
        {
        }

        public Action<string> SetClientMessage { get; set; }

        public static OurProxy GetProxy()
        {
            return _instance;
        }

        public string StartMessage { get; set; }
        public void GetMessage(string message)
        {
            
        }
    }
}
