using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBaseExample
{
    public class Kutya : Állat
    {

        public Kutya()
        {
            this.Név = "Kutya";
        }

        public override string HangotAd()
        {
            return "Vau vau";
        }
    }
}
