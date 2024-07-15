using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public  class Item<T> 
    {
        private T date;

        public  Item<T> Next { get; set; } 


        public T Date
        {
            get { return date; }
            set 
            { 
                date = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public Item(T data)
        {
            Date = data;

        }

        public override string ToString()
        {
            return Date.ToString();
        }

      
    }
}
