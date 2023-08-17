using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_m8_t4 {
    internal class Program {
        static void Main(string[] args) {

            Person person = new Person();

            //Validate FullName field
            while (true) {
                Console.Write("Введите ФИО персоны: ");
                if (!person.SetPersonName(Console.ReadLine())) {
                    Console.WriteLine("Неверный ввод.\n");
                } else {
                    break;
                }
            }
            Console.WriteLine();

            //Validate Street field
            while (true) {
                Console.Write("Введите название улицы: ");
                if (!person.SetPersonStreet(Console.ReadLine())) {
                    Console.WriteLine("Неверный ввод.\n");
                } else {
                    break;
                }
            }
            Console.WriteLine();

            //Validate Building field
            while (true) {
                Console.Write("Введите номер дома: ");
                if (!person.SetPersonBulding(Console.ReadLine())) {
                    Console.WriteLine("Неверный ввод.\n");
                } else {
                    break;
                }
            }
            Console.WriteLine();

            //Validate Apartment field
            while (true) {
                Console.Write("Введите номер квартиры: ");
                if (!person.SetPersonApt(Console.ReadLine())) {
                    Console.WriteLine("Неверный ввод.\n");
                } else {
                    break;
                }
            }
            Console.WriteLine();

            //Validate MobileNumber field
            while (true) {
                Console.Write("Введите номер мобильного телефона: ");
                if (!person.SetPersonMobile(Console.ReadLine())) {
                    Console.WriteLine("Неверный ввод.\n");
                } else {
                    break;
                }
            }
            Console.WriteLine();

            //Validate HomeNumber field
            while (true) {
                Console.Write("Введите номер домашнего телефона: ");
                if (!person.SetPersonHomeNumber(Console.ReadLine())) {
                    Console.WriteLine("Неверный ввод.\n");
                } else {
                    break;
                }
            }

            person.WriteToFile();

            Console.WriteLine("Данные сохранены в XML файл.");
            Console.ReadKey();

        }
    }
}
