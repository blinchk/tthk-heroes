using System;

namespace TthkHeroes.Models
{
    public class Hero
    {
        public Hero(string name)
        {
            Name = name;
        }
        
        public Hero(string name, string location)
        {
            Name = name;
            Location = location;
        }
        
        public string Name { get; set; }
        public string Location { get; set; }

        public int CalculateSavedPeople(int people)
        {
            if (people < 1) throw new ArgumentException("People number cannot be less than one.");
            var savedPeople = people * 0.95;
            return (int)savedPeople;
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name)) throw new FormatException("Cannot return string of hero without name.");
            if (String.IsNullOrEmpty(Location))
            {
                return $"Kanglane {Name} ei kaitse linna";
            }
            return $"Kanglane {Name} kaitseb linna {Location}";
        }
    }
}