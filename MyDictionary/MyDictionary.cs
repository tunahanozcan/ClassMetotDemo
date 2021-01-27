using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] tkeys;
        Tvalue[] tvalues;

        public MyDictionary()
        {
            tkeys = new Tkey[0];
            tvalues = new Tvalue[0];
        }

        public void Add(Tkey anahtar,Tvalue deger)
        {
            Tkey[] tempArray = tkeys;
            Tvalue[] tempArray2 = tvalues;

            tkeys = new Tkey[tkeys.Length + 1];
            tvalues = new Tvalue[tvalues.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tkeys[i] = tempArray[i];
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                tvalues[i] = tempArray2[i];
            }

            tkeys[tkeys.Length - 1] = anahtar;
            tvalues[tvalues.Length - 1] = deger;
        }

        public Tkey[] No
        {
            get { return tkeys; }
        }
        public Tvalue[] Isım
        {
            get { return tvalues; }
        }
    }
}
