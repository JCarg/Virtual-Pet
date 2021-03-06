﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class Virtual_Pet
    {
        //fields
        public int age;
        public string mood;
        public string boon;
        private int hunger;
        private int boredom;
        private int health=20;
        private int energy;


        //properties
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public int Energy
        {
            get { return this.energy; }
            set { this.energy = value; }
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
            int moodChoice = randnum.Next(1,6);
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
            if (boon == "Never Fatigued")
            {
                this.hunger += 5;
                this.energy = 20;
                this.boredom += 1;
                this.health -= 1;
            }
            else if (boon == "Never Hungry")
            {
                this.hunger = 0;
                this.energy += 10;
                this.boredom += 3;
                this.health -= 1;
            }
            else if (boon == "Never Bored")
            {
                this.hunger += 5;
                this.energy += 10;
                this.boredom = 0;
                this.health -= 1;
            }


        }
         
        public void Feed()
        {   if (boon == "Never Hungry")
            {
                this.hunger = 0;
                this.energy -= 1;
                this.boredom += 3;
                this.health -= 1;
            }
            else if(boon == "Never Bored")
            {
                this.hunger -= 2;
                this.energy -= 1;
                this.boredom = 0;
                this.health -= 1;
            }
            else if(boon=="Never Fatigued")
            {
                this.hunger -= 2;
                this.energy = 20;
                this.boredom += 3;
                this.health -= 1;
            }
    }

        public void Play()
        {
            if (boon == "Never Bored")
            {
                this.hunger += 5;
                this.energy -= 4;
                this.boredom = 0;
                this.health += 1;
            }
            else if (boon == "Never Hungry")
            {
                this.hunger = 0;
                this.energy -= 4;
                this.boredom -= 3;
                this.health += 1;
            }
            else if (boon == "Never Fatigued")
            {
                this.hunger += 5;
                this.energy = 20;
                this.boredom -= 3;
                this.health += 1;
            }


        }

        public void Medecine()
        {
            if (boon == "Never Fatigued")
            {
                this.hunger += 5;
                this.energy = 20;
                this.boredom += 2;
                this.health += 3;
            }
            else if (boon == "Never Hungry")
            {
                this.hunger = 0;
                this.energy -= 3;
                this.boredom += 3;
                this.health += 3;
            }
            else if (boon == "Never Bored")
            {
                this.hunger += 5;
                this.energy -= 3;
                this.boredom = 0;
                this.health += 3;
            }
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
       
    }
}

