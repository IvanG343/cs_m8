using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_m8_t1 {
    internal class MyList {

        Random rnd = new Random();

        public List<int> FillList(List<int> list, int count) {
            for (int i = 0; i < count; i++) {
                list.Add(rnd.Next(0, 101));
            }
            return list;
        }

        public void PrintList(List<int> list) {
            foreach (var e in list) {
                Console.Write($"{e} / ");
            }
            Console.WriteLine("\n***************************************************************\n");
        }

        public List<int> RemoveFromList(List<int> list, int removeFrom, int removeTo) {
            for (int i = 0; i < list.Count;) {
                if (list[i] > removeFrom && list[i] < removeTo) {
                    list.RemoveAt(i);
                    continue;
                }
                i++;
            }

            return list;
        }

    }
}
