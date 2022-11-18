using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
   public class Language
    {
        public string Name { get; set; }
        public DateTime CreatingDate { get; set; }
        public int Power { get; set; }
        public int Popularity { get; set; }
        public Language(string name,DateTime creatingdate,int power,int popularity)
        {
            Name = name;
            CreatingDate = creatingdate;
            Power = power;
            Popularity = popularity;
        }
        
    }
}
