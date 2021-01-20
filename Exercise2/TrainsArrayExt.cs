using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    static class TrainsArrayExt
    {
        public static string GetDetailsByNumber(this Train[] trains, string number)
        {
            string result = String.Empty;

            foreach (var train in trains)
            {
                if (train.Number.Equals(number))
                {
                    result += train.ToString() + "\n";
                }
            }

            if (result == string.Empty)
            {
                result = "Не удалось найти поезд с указанным номером";
            }
            return result;
        }

        public static void SortAsc(this Train[] trains)
        {
            for (int i = 1 ; i < trains.Length; i++)
            {
                for (int j = 1; j < trains.Length; j++)
                {
                    if (trains[j].Number.CompareTo(trains[j - 1].Number) < 1)
                    {
                        Train temp = trains[j];
                        trains[j] = trains[j - 1];
                        trains[j - 1] = temp;
                    }
                }
            }
        }
    }
}
