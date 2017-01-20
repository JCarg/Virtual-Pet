using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instance Creation
            Virtual_Pet Pet = new Virtual_Pet();
            //User output
            Console.WriteLine("Name your pet: ");           
            string petname = Console.ReadLine();       
            Console.WriteLine(petname + " the Batman");
            Pet.DisplayStaticStats();

            do
            {
                Pet.DisplayChangingStats();
                
                Console.WriteLine("\nChoose a selection: \n");
                Console.WriteLine("1. Feed " + petname);
                Console.WriteLine("2. Play with " + petname);
                Console.WriteLine("3. Give Medecine to " + petname);
                Console.WriteLine("4. Put "+petname+ " to sleep");
                int userchoice = int.Parse(Console.ReadLine());
                if (userchoice == 1)
                {
                    Pet.Feed();
                }
                else if (userchoice == 2)
                {
                    Pet.Play();
                }
                else if (userchoice == 3)
                {
                    Pet.Medecine();
                }
                else if (userchoice == 4)
                {
                    Pet.Sleep();
                }
            }
            while (Pet.Energy > 0||Pet.Boredom<20||Pet.Health>0||Pet.Hunger>0);
            {
                if(Pet.Energy==0)
                {
                    Console.WriteLine("You're neglectful. You lost your pet!");
                }
            }

            







              
        }
        static void function()
        {
            Virtual_Pet Pet = new Virtual_Pet();
            int userchoice = int.Parse(Console.ReadLine());
            if (userchoice == 1)
            {
                Pet.Feed();
            }
            else if (userchoice == 2)
            {
                Pet.Play();
            }
            else if (userchoice == 3)
            {
                Pet.Medecine();
            }
            else if (userchoice == 4)
            {
                Pet.Sleep();
            }
            Pet.DisplayChangingStats();
        }
       
            
        }
    }

