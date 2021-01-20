using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class TrainCreator
    {
        public static Train Create()
        {
            Console.WriteLine("Введите номер поезда:");
            string number = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine("Введите пункт назначения: ");
            string destination = Console.ReadLine();
            Console.Write("\n");

            Console.WriteLine("Введите дату отправления в формате MM/DD/YYYY 00:00:00 ");
            string date = Console.ReadLine();
            Console.Write("\n");

            return new Train(destination, number, DateTime.Parse(date));
        }
    }
}
