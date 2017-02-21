using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBaseExample
{
    public abstract class Állat
    {
        public string Név { get; set; }


        public Állat()
        {
            this.Név = "Állat";
        }

        public virtual string HangotAd()
        {
            return "Üres";
        }
    }
}
