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


        //constructor
        public Virtual_Pet()//Gives stats to Pet
        {
            this.age = RandomStat();
            this.hunger = RandomStat();
            this.boredom = RandomStat();
            this.energy = RandomStat();
            this.mood = MoodChoice();
            this.boon = BoonChoice();
        }
         




        //methods
        public string MoodChoice()// Chooses random mood for user's pet
        {
            Random randnum = new Random();
            int moodChoice = randnum.Next(6);
            switch (moodChoice)
            {
                case 1:
                    mood = "Happy";
                    break;
                case 2:
                    mood = "Sad";
                    break;
                case 3:
                    mood = "Vindictive";
                    break;
                case 4:
                    mood = "Needy";
                    break;
                case 5:
                    mood = "Playful";
                    break;
            }
            return mood;
        }

        //public void AgeChoice()// Chooses random age for user's pet
        //{
        //    Random randnum = new Random();
        //    this.age = randnum.Next(1, 20);
        //}

        public string BoonChoice()// Chooses random Boon
        {
            Random randnum = new Random();
            int BoonNumber = randnum.Next(1, 4);
            switch(BoonNumber)
                {
                case 1:
                    boon = ("Never Fatigued");
                    this.energy = 20;
                    break;
                case 2:
                    boon = ("Never Hungry");
                    this.hunger = 0;
                    break;
                case 3:
                    boon = ("Never Bored");
                    this.boredom = 0;
                    break;
            }
            return boon;
        }

        //actions for the user to take
        public void Sleep()
        {
            if (boon != "Never Fatigued")
            {
                this.energy += 2;
            }
            else
            {
                this.energy += 0;
            }
        }

        public void Feed()
        {   if (boon != "Never Hungry")
            {
                this.hunger -= 2;
            }
            else
            {
                this.hunger += 0;
            }
        }

        public void Play()
        {
            if (boon != ("Never Bored"))
            {
                this.boredom -= 2;
            }
            else
            {
                this.boredom += 0;
            }
        }

        public void Medecine()
        {
            this.health += 2;
        }

        public int RandomStat()
        {
            Random rand = new Random();
            int stat = rand.Next(21);
            return stat;
        }

        //Displaying Stats Method

        public void DisplayChangingStats()
        {
            Console.WriteLine("Energy: "+energy);
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Health: " + health);
        }

        public void DisplayStaticStats()
        {
            Console.WriteLine("Your pet is " + age + " years old. They are " + mood + " and " + boon);
        }
       
    }
}

