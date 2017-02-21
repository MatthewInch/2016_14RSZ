using OOPBaseExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Állat> állatok = new List<Állat>();

            Random rnd = new Random();
            for (int i=0;i<10;i++)
            {
                if (rnd.Next(2) == 0)
                {
                    állatok.Add(new Kutya());
                }
                else
                {
                    állatok.Add(new Macska());
                }
            }

            foreach (Állat állat in állatok)
            {
                Console.WriteLine($"Az állat fajtája: {állat.Név}; Hangja: {állat.HangotAd()}");
            }

        }
    }
}
