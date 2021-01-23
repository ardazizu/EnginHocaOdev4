using System;
using System.Collections.Generic;
using System.Text;

namespace EnginHocaOdev_4
{
    class Mydictionary<TKey,TValue>
    {
        TKey[] keyArray;
        TValue[] keyValue;
        public Mydictionary()
        {
            keyArray = new TKey[0];
            keyValue = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {   
            TKey[]tempkeyArray = keyArray;
            TValue[]tempkeyValue = keyValue;
            keyArray = new TKey[keyArray.Length+1];
            keyValue = new TValue[keyValue.Length+1];


            for (int i = 0; i < tempkeyArray.Length; i++)
            {
                keyArray[i] = tempkeyArray[i];
            }

            for (int j = 0; j < tempkeyValue.Length; j++)
            {
                keyValue[j] = tempkeyValue[j];
            }

            keyArray[keyArray.Length - 1] = key;
            keyValue[keyValue.Length - 1] = value;
         





        }

        public int Length
        {

           get { return keyArray.Length; }
           

        }
       
       
      
        

    }
}
