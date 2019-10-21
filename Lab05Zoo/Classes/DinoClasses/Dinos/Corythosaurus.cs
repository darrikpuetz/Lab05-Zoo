using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Omnivore
    {
        public string name;
        public bool isIdiot;
        public int numberOfCats;
        private string hairColor;

        public Omnivore(string name, bool isIdiot, int numberOfCats)
        {
            Console.WriteLine($"I am a constructor for {name}");
            IsIdiot = isIdiot;
            Name = name;
            HairColor = hairColor;
            NumberOfCats = numberOfCats;

        }


        //public int GetMoreCats(inputCats, int value)
        //{
        //    int numberOfCatsNew = inputCats + (value);
        //    return numberOfCatsNew;
        //}
        //private string ChangeHair(string input)
        //{
        //    string newHair = input;
        //    return input;
        //}

        private int _numberofCats;
        public int NumberOfCats
        {
        }
    }
