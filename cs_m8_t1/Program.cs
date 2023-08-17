using System;
using System.Collections.Generic;

namespace cs_m8_t1 {
    internal class Program {
        static void Main(string[] args) {

            MyList lst = new MyList();

            List<int> list = new List<int>();
            List<int> listFiltered = new List<int>();

            list = lst.FillList(list, 100);
            Console.WriteLine($"Filled list[{list.Count}]: \n");
            lst.PrintList(list);


            listFiltered = lst.RemoveFromList(list, 25, 50);
            Console.WriteLine($"Filtered list[{listFiltered.Count}]: \n");
            lst.PrintList(listFiltered);

            listFiltered.Sort();
            Console.WriteLine($"Filtered sorted list[{listFiltered.Count}]: \n");
            lst.PrintList(listFiltered);

            Console.ReadKey();
        }
    }
}
