using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
            return _proxy.StartMessage;
        }

        public void SendMessage(string Message)
        {
            _proxy.GetMessage(Message);
        }
    }
}
