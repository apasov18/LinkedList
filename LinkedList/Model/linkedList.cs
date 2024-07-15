using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public  class LinkedList<T> : IEnumerable
    {
        public Item<T> Head {get;private set;}
        public Item<T> Tail { get;private set;}
        public int Count { get;private set;}

        public LinkedList()
        {
            Clear();
        }

        public LinkedList( T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(data);
        }

        public void Add( T data )
        {
          
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);

            }
        }

        public void Delete ( T data ) 
        {
            if (Head!= null)
            {
                if (Head.Date.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var cuurrent = Head.Next;
                var previous =  Head;
                while (cuurrent != null)
                {
                    if (cuurrent.Date.Equals(data))
                    {
                        previous.Next= cuurrent.Next;
                        Count--;
                        return;
                    }
                    previous = cuurrent;
                    cuurrent= cuurrent.Next;
                }
            }
        
        
        }

       

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        
        private void SetHeadAndTail( T data )
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null) 
            {
                yield return current.Date; 
                current = current.Next;
            
            }
        }

        public override string ToString()
        {
            return "Linked List " + Count + "items";
        }
    }
}
