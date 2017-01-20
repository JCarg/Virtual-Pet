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


            Console.WriteLine("Name your pet: ");
            string petname = Console.ReadLine();
            Pet.DisplayStaticStats();

            Pet.DisplayChangingStats();
            Console.WriteLine(petname + " the Batman");
            Console.WriteLine("Choose a selection: ");
            Console.WriteLine("1. Feed " + petname);
            Console.WriteLine("2. Play with" + petname);
            Console.WriteLine("3. Give Medecine" + petname);
            Console.WriteLine("4. Put to sleep" + petname);

            int userchoice = int.Parse(Console.ReadLine());
            if (userchoice==1)
            {
                Pet.Feed();
            }
            else if(userchoice==2)
            {
                Pet.Play();
            }
            else if(userchoice==3)
            {
                Pet.Medecine();
            }
            else if(userchoice==4)
            {
                Pet.Sleep();
            }

            
            Pet.DisplayStaticStats();

            // User stat choices
            Pet.BoonChoice();
            Pet.Feed();
            Pet.Medecine();
            Pet.Play();          
        }
        static void function()
        {

        }
    }
}
