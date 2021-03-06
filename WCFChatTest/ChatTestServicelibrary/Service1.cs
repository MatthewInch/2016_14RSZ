﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Web;

namespace ChatTestServicelibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private ChatProxy _proxy = ChatProxy.GetProxy();

        public int CountALetter(string value)
        {
            return value.Where(c => c == 'a' || c == 'A').Count();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Service1()
        {
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetDefaultMessage()
        {
            return _proxy.GetDefaultMessage(GetIP());
        }

        public void SendMessage(string Message)
        {
            _proxy.GetMessage(Message, GetIP());
        }

        private string GetIP()
        {
            OperationContext context = OperationContext.Current;
            MessageProperties prop = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpoint =
                prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            return endpoint.Address;
        }
    }
}
