using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IntercaceTest
{

    public class SzámtaniSor: IEnumerable, IEnumerator
    {
        public IEnumerator GetEnumerator()
        {
            return this;
        }

            private int _n;
            private int _lépésMéret;
            private int _current;
            public SzámtaniSor(int n, int lépésMéret)
            {
                _n = n;
                _lépésMéret = lépésMéret;
            }
            public object Current
            {
                get
                {
                    return _current;
                }
            }

            public bool MoveNext()
            {
                if (_current + _lépésMéret < _n)
                {
                    _current = _current + _lépésMéret;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                _current = 0;
            }

    }


    class Program
    {
        static void Main(string[] args)
        {
            SzámtaniSor számtaniSor = new SzámtaniSor(30, 7);
            foreach (var  sz in számtaniSor)
            {
                Console.WriteLine(sz);
            }

        }
    }
}
