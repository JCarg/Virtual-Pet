using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class Virtual_Pet
    {
        //fields
        private int age;
        private string mood;
        private string boon;
        


        //properties
        public int Age
        {
            get { return this.age; }
        }

        public string Mood
        {
            get { return this.mood; }
        }

        public string Boon
        {
            get { return this.boon; }
        }


        //constructors

         




        //methods
        public void MoodChoice()
        {
            Random randnum = new Random();
            int moodChoice = randnum.Next(6);
            switch (moodChoice)
            {
                case 1:
                    this.mood = "Happy";
                    break;
                case 2:
                    this.mood = "Sad";
                    break;
                case 3:
                    this.mood = "Vindictive";
                    break;
                case 4:
                    this.mood = "Needy";
                    break;
                case 5:
                    this.mood = "Playful";
                    break;
            }
        }

        public void AgeChoice()
        {
            Random randnum = new Random();
            this.age = randnum.Next(1, 20);
        }

        public void BoonChoice()
        {
            Random randnum = new Random();
            int BoonNumber = randnum.Next(1, 4);
            switch(BoonNumber)
                {
                case 1:
                    this.Boon("Never Fatigued");
                    break;
                case 2:
                    Console.WriteLine()

            }
        }


    }
}

