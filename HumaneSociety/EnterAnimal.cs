using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class EnterAnimal : UI
    {
        public EnterAnimal()
        {
                
        }

        public void GetEnterAnimal()
        {
            string animalType;
            int? enterAnimal = null;
            enterAnimal = Console.Read();
            Console.WriteLine("What type of Animal are you bringing us today? /nWe only accept; (Choose 1 - 3) \n1. Dog \n2. Cat \n3. Bird. \n>>");
            Console.ReadLine();
            if (true)
            {
                Console.WriteLine(enterAnimal.HasValue);
                
            }
            else
            {

            }
        }
    }
}
