using System;
using System.Collections.Generic;
using System.Text;

namespace Node_Yer_Degistirme
{
    class DoubleLinkedList<T>
    {
        public Node first;
        private Node last;
        public class Node
        {
            public Node(T data)
            {
                this.data=data  ;
            }
            public Node next;
            public Node prev;
            public T data;
        }
         public void AddLast(T veri)
         {
             Node newnode = new Node(veri);
             if (first==null)
             {
                 first = last= newnode;
             }
             else
             {
                 last.next = newnode;
                 newnode.prev = last;
                 last = newnode;
             }
         }

         public void Showlist()
         {
            Node trvl = first;
            while (trvl != null)
            {
                Console.WriteLine(trvl.data);
                trvl = trvl.next;
            }

            /* Node trvl = last;
             while (trvl != null)
             {
                 Console.WriteLine(trvl.data);
                 trvl = trvl.prev;
             }*/
        }

         public void YerDegistir(Node b,Node c)
         {

             //Node p,Node k olursa....
            /* p.prev.next = k;
               k.prev = p.prev;
               k.next.prev = p;
               p.next = k.next;
               k.next = p;
               p.prev = k;   */

               b.next = c.next;
               c.prev = b.prev;
               c.next.prev = b;
               c.next = b;
               b.prev.next = c;
               b.prev = c;

        }




    }
   
}
