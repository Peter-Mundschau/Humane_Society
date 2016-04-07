using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Dog : Animal
    {
        
        public Dog (string animalType,string animalName,float animalWeight,bool hasShots,bool isSick, bool isFed, int kennelNumber, int animalId ):base(animalType,animalName,animalWeight,hasShots,isSick,isFed,kennelNumber,animalId)
        {
            animalType = "Dog";
        }


        
    
    }
}
