using System;
using System.Collections.Generic;

namespace cs_m8_t2 {
    class Contacts {
        Dictionary<long, string> contactList = new Dictionary<long, string>();

        public void AddContact() {
            while (true) {
                Console.Write("\nВведите номер телефона (или пустую строку для завершения): ");
                string phoneNumberInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(phoneNumberInput))
                    break;

                if (long.TryParse(phoneNumberInput, out long phoneNumber)) {
                    if (IsExist(phoneNumber)) {
                        Console.WriteLine("Номер уже добавлен.");
                        Console.ReadKey();
                        continue;
                    }

                    Console.Write("Введите ФИО владельца: ");
                    string ownerName = Console.ReadLine();

                    contactList.Add(phoneNumber, ownerName);
                } else {
                    Console.WriteLine("Номер телефона должен быть числом.");
                }
            }
        }

        public void SearchContact() {
            Console.Write("\nВведите номер для поиска: ");
            string phoneNumberInput = Console.ReadLine();

            if (long.TryParse(phoneNumberInput, out long phoneNumber)) {
                if (contactList.TryGetValue(phoneNumber, out string ownerName)) {
                    Console.WriteLine($"Номер {phoneNumber} принадлежит {ownerName}");
                    Console.ReadLine();
                } else {
                    Console.WriteLine($"Номер {phoneNumber} не найден");
                    Console.ReadLine();
                }
            }
        }

        private bool IsExist(long number) {
            bool result = false;
            foreach (var e in contactList) {
                if (number == e.Key) {
                    result = true;
                } else {
                    result = false;
                }
            }
            return result;
        }
    }
}