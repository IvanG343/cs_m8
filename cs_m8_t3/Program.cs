using System;
using System.Threading;

namespace cs_m8_t3 {
    internal class Program {

        static void Main(string[] args) {

            MyHashSet mhs = new MyHashSet();

            while (true) {
                Console.Write("Введите число для ввода или пустую строку для выхода: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int number)) {
                    if (mhs.AddToHashSet(number)) {
                        Console.WriteLine($"Число {number} добавлено в коллекцию.\n");
                    } else {
                        Console.WriteLine($"Число {number} уже присутствует в коллекции.\n");
                    }

                } else if (string.IsNullOrEmpty(userInput)) {
                    Console.WriteLine("Завершение программы.");
                    Thread.Sleep(1000);
                    break;
                } else {
                    Console.WriteLine("Неверный ввод.\n");
                }
            }

        }

    }

}