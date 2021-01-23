using System;

namespace Node_Yer_Degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> exmp = new DoubleLinkedList<int>();
            exmp.AddLast(15);
            exmp.AddLast(16);
            exmp.AddLast(17);
            exmp.AddLast(18);
            exmp.AddLast(19);
            exmp.AddLast(120);

            exmp.Showlist();
            exmp.YerDegistir(exmp.first.next, exmp.first.next.next);
            Console.WriteLine("**********************************");
            exmp.Showlist();
        }
    }
}
