using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_m8_t2 {
    internal class Program {
        static void Main(string[] args) {

            Contacts contacts = new Contacts();

            bool isProgramRunning = true;

            while (isProgramRunning) {

                Console.WriteLine("Справочник контактов");
                Console.WriteLine("Введите 1 чтобы создать новый контакт");
                Console.WriteLine("Введите 2 чтобы найти контакт по номеру");
                Console.WriteLine("Введите 0 для выхода из программы");
                Console.Write("Ваш выбор: ");

                if (int.TryParse(Console.ReadLine(), out int choice)) {
                    switch (choice) {
                        case 1:
                            contacts.AddContact();
                            Console.Clear();
                            break;
                        case 2:
                            contacts.SearchContact();
                            Console.Clear();
                            break;
                        case 0:
                            isProgramRunning = false;
                            break;
                        default:
                            Console.WriteLine("Неверная команда");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                } else {
                    Console.WriteLine("Неверная команда");
                    Console.ReadKey();
                    Console.Clear();
                }

            }

        }
    }
}
