using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Menu
    {
        public static void Show()
        {
            const int trainCount = 8;

            Train[] trains = new Train[trainCount];
            Console.WriteLine($"Необходимо ввести данные о {trains.Length} поездах.\n");

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Поезд {i + 1}\n");
                trains[i] = TrainCreator.Create();
            }

            trains.SortAsc();

            Console.WriteLine("Данные о поездах, сортированные по номеру поезда:");

            foreach (var train in trains)
            {
                Console.WriteLine(train.ToString() + "\n");
            }

            Console.WriteLine("Нажмите любую кнопку для продолжения.\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Выполните поиск по номеру поезда.\n");
            string number = Console.ReadLine();
            Console.WriteLine(trains.GetDetailsByNumber(number));
        }
    }
}
