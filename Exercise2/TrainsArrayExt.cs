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
    }
}
