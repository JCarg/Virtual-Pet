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
            Console.WriteLine("This is "+petname + " the Monkey. Your new pet!");
            Console.WriteLine("   .=\"=.");
            Console.WriteLine(" _/.-.-.\\_");
            Console.WriteLine("( ( o o ) )");
            Console.WriteLine(" |/  \"  \\| ");
            Console.WriteLine("  \\'---'/");
            Console.WriteLine("  /`\"\"\"`\\\\");
            Console.WriteLine(petname + " is " + Pet.age + " years old. They are " + Pet.mood + " and " + Pet.boon + ".");

            //Loop to display and affect the statistics of the pet. Health, Hunger, Boredom, and Energy are the stats.
            do
            {               
                Pet.DisplayChangingStats();
                Begin:              
                Console.WriteLine("\nChoose a selection: \n");
                Console.WriteLine("1. Feed " + petname);
                Console.WriteLine("2. Play with " + petname);
                Console.WriteLine("3. Give Medecine to " + petname);
                Console.WriteLine("4. Put "+petname+ " to sleep\n");
                int userchoice = int.Parse(Console.ReadLine());
                if (userchoice == 1)
                {
                   
                    Pet.Feed();                
                }
                else if (userchoice == 2)
                {
                    //Pet.StatDeteriorator();
                    Pet.Play();
                   
                }
                else if (userchoice == 3)
                {
                    //Pet.StatDeteriorator();
                    Pet.Medecine();                   
                }
                else if (userchoice == 4)
                {
                    //Pet.StatDeteriorator();
                    Pet.Sleep();               
                }
                else
                {
                    goto Begin;
                }
                if(Pet.Energy<=0||Pet.Hunger>=20||Pet.Health<=0||Pet.Boredom>=20)
                {
                    Console.WriteLine("You're neglectful. You lost your pet!");
                    Console.WriteLine("Poor " + petname + "!");
                    Console.WriteLine("   .-\"-.");
                    Console.WriteLine(" _/.-.-.\\_");
                    Console.WriteLine("(  (o o)  )");
                    Console.WriteLine(" |/  \"  \\|");
                    Console.WriteLine("  \\ .-. /");
                    Console.WriteLine("  /`\"\"\"`\\");
                    break;
                }
                
            }
            while (Pet.Energy > 0||Pet.Boredom<20||Pet.Health>0||Pet.Hunger>0);              
        }
                 
        }
    }

