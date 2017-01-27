using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
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
                if (index > 0)
                    index = index + 1;

                var item = items[index];
                return item;
            }
            set
            {
                items[index] = value;
            }
        }
        class Program
        {
           public static void Main(string[] args)
            {
                Console.WriteLine("Enter the value");
                int value = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
               
   
