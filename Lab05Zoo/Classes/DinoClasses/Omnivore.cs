using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class OmniVore
    {
        public string name;
        public bool isIdiot;
        public int numberOfCats;
        private string hairColor;

        public OmniVore(string name, bool isIdiot, int numberOfCats)
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
            get
            {
                return _numberofCats;
            }
            private set
            {
                if (value > 0)
                {
                    _numberofCats = value;
                }
                else
                {
                    throw new ArgumentException(" -Negative Cat's is a crime.");
                }

            }

        }
        public string Name { get; }
        public int HasCats { get; set; }
        public bool IsIdiot { get; private set; }
        public string HairColor { get; set; }
        bool canHelp()
        {
            if (IsIdiot)
            {
                return true;
            }
            return false;
        }
        //    void canHelp()
        //    {

        //    }
    }
}
