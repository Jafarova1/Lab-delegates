using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        public delegate T Power<T>(int power, string name);
        public delegate T Date<T>(int power, string name);

        static void Main(string[] args)
        {
           
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

        }
        public static void GetUsefulLanguages(Dictionary<int, string> dictionary,Power<int> power,Date<DateTime> date)
        {
            

        }
        public static string CheckPower(int power,string name)
        {
            if (power > 100)
            {
                return $"{name} {power} yeterlidir ";
            }
            else
            {
                return $"{power} {name} yeterli deyil";
            }
        }
        public static bool CheckCreatingDate(DateTime date)
        {
           DateTime date1=date.AddDays(-500);
            
            if (date1 == date)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public static int UpdatePopularity(int popularity)
        {
            return popularity * 2;
        }
    }
}
