using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    struct Train : IComparable<Train>
    {
        public string Destinastion { get; private set; }
        public string Number { get; private set; }
        public DateTime DepartureAt { get; private set; }
        public Train(string destinastion, string number, DateTime departureAt)
        {
            Destinastion = destinastion;
            Number = number;
            DepartureAt = departureAt;
        }
        public override string ToString()
        {
            return $"Номер поезда: {Number}\n" +
                   $"Пункт назначения: {Destinastion}\n" +
                   $"Дата отправления: {DepartureAt:F}\n";
        }

        public int CompareTo(Train obj)
        {
            return Number.CompareTo(obj.Number);
        }
    }
}
