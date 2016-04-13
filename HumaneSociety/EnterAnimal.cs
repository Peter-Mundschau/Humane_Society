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
            //string animalType;
            //int? enterAnimal = null;
            //enterAnimal = Console.Read();
            Console.WriteLine("What type of Animal are you bringing us today? /nWe only accept; (Choose 1 - 3) \n1. Dog \n2. Cat \n3. Bird. \n>>");
            string AnimalType = Console.ReadLine();
            Console.WriteLine("Enter the Name of the Animal\n>>");
            string AnimalName = Console.ReadLine();
            Console.WriteLine("Enter the Animals Weight in pounds\n>>");
            double AnimalWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Is the Animal upto date on Shots?\n(Y or N)>>");
            bool HasShots = bool.Parse(Console.ReadLine());
            {
                string[] values = { null, String.Empty, "True", "False",
                          "true", "false", "    true    ", "0",
                          "1", "-1", "string" };
                foreach (var value in values)
                {
                    bool flag;
                    if (Boolean.TryParse(value, out flag))
                        Console.WriteLine("'{0}' --> {1}", value, flag);
                    else
                        Console.WriteLine("Unable to parse '{0}'.",
                                          value == null ? "<null>" : value);
                }




            }
        }
    }
}
