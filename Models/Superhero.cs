using System;

namespace TthkHeroes.Models
{
    public class Superhero : Hero
    {
        private double _agility;
        private static readonly Random RandomAgility = new Random();
        public Superhero(string name): base(name)
        {
            Name = name;
            _agility = CalculateRandomAgility();
        }
        
        public Superhero(string name, string location): base(name, location)
        {
            Name = name;
            Location = location;
            _agility = CalculateRandomAgility();
        }

        private double CalculateRandomAgility()
        {
            return RandomAgility.NextDouble() * (5-1) + 1;
        }
        
        public new int CalculateSavedPeople(int people)
        {
            var savedPeople = people * (0.95 + (_agility / 100));
            return (int)savedPeople;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nLisaks on tal {_agility:N2} punkti kavalust.";
        }    
    }
}