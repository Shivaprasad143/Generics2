using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public class MyList<T> 
    {
        private int size;

        private T[] items;

        public MyList(int size)
        {
            this.size = size;
            this.items = new T[size];
        }
        
        public T this[int index]    // Indexer declaration  
        {
            get
            {
                var item = items[index];
                return item;
            }
            set
            {
                items[index] = value;
            }
        }
    }
}
