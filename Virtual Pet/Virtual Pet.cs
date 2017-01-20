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
        private int hunger;
        private int boredom;
        private int health=20;
        private int energy;


        //properties
        public int Hunger
        {
            get { return this.hunger; }
        }

        public int Boredom
        {
            get { return this.boredom; }
        }

        public int Health
        {
            get { return this.health; }
        }

        public int Energy
        {
            get { return this.energy; }
        }


        //constructors

         




        //methods
        public void MoodChoice()// Chooses random mood for user's pet
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

        public void AgeChoice()// Chooses random age for user's pet
        {
            Random randnum = new Random();
            this.age = randnum.Next(1, 20);
        }

        public void BoonChoice()// Chooses random Boon
        {
            Random randnum = new Random();
            int BoonNumber = randnum.Next(1, 4);
            switch(BoonNumber)
                {
                case 1:
                    this.boon = ("Never Fatigued");
                    this.energy = 100;
                    break;
                case 2:
                    this.boon = ("Never Hungry");
                    this.hunger = 0;
                    break;
                case 3:
                    this.boon = ("Never Bored");
                    this.boredom = 0;
                    break;
            }
        }

        public void Sleep()
        {
            if (boon != "Never Fatigued")
            {
                this.energy += 2;
            }
        }

        public void Feed()
        {   if (boon != "Never Hungry")
            {
                this.hunger -= 2;
            }
        }

        public void Play()
        {
            if (boon != ("Never Bored"))
            {
                this.boredom -= 2;
            }
        }

        public void Medecine()
        {
            this.health += 2;
        }
    }
}

