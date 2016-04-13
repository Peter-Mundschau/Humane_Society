using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Bird : Animal
    {
        public Bird(string animalType, string animalName, double animalWeight, bool hasShots, bool isSick, bool isFed, int kennelNumber, int animalId) : base(animalType, animalName, animalWeight, hasShots, isSick, isFed, kennelNumber, animalId)
        {
            animalType = "Bird";
        }
    }
}
