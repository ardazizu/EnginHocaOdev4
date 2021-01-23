using System;
using System.Collections.Generic;
using System.Text;

namespace EnginHocaOdev4
{
    class MyList<T>
    {
        T [] items;
        public MyList()
        {

            items = new T[0];
        }
        public void Add( T item )
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
         
        
            
            
            }
            //itemsın son elemanı uzunluğunun bir eksiği 6 elemanlıysa 5. index verir.
            items[items.Length - 1] = item;
        
        
        
        
        }

        public int Length
        {

            get { return items.Length; }
        
        
        }

        public T[] Items
        {
            get { return items; }
        }

    }
}
