using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class UI
    {
        public AdoptionOp AdoptionOps;
        public MedicalOp MedicalOps;
        public EnterAnimal EnterAnimals;
        public UI()
        {
            AdoptionOps = new AdoptionOp();
            MedicalOps = new MedicalOp();
            EnterAnimals = new EnterAnimal();
          
        }

        public void UserInterface()
        {
            
            
            int userInput;
            userInput = Console.Read();

            Console.WriteLine("Please Choose from the following");
            Console.WriteLine("1.   Enter a new Animal into the System");
            Console.WriteLine("2.   Remove an Animal from the System");
            Console.WriteLine("3.   Get a List of Animals that have had their shots.");
            Console.WriteLine("4    Get a List of Animals by Type");
            Console.WriteLine("5    Get a List of Animals by Kennel #");
            Console.Read();
            switch (userInput)
            {
                case 1:
                   
                   // AdoptionOps.addAnimal();
                    break;
                case 2:
                    AdoptionOps.removeAnimal();
                    break;
                case 3: 


                default:
                    throw new Exception("Not a Valid Choice");
            }




        }



    }
}
