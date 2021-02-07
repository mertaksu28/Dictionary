using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<Akey, Bvalue>
    {
        Akey[] keys;
        Bvalue[] values;
        public MyDictionary()//Constructor
        {
            keys = new Akey[0];
            values = new Bvalue[0];

        }

        public void Add(Akey key, Bvalue value)
        {
            Akey[] tempArray1 = keys;
            Bvalue[] tempArray2 = values;
            keys = new Akey[keys.Length + 1];
            values = new Bvalue[values.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempArray2.Length; i++)
            {
                values[i] = tempArray2[i];
            }
            values[values.Length - 1] = value;


        }
        public int Length
        {
            get { return keys.Length; }
            
        }
        public Akey[] Keys
        {
            get { return keys; }
        }
    }
}
