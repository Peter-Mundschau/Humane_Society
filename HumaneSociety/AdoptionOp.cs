using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class AdoptionOp : Animal

    {
        public Animal(string animalType, string animalName, float animalWeight, bool hasShots, bool isSick, bool isFed, int kennelNumber)

        {
            this.animalType = animalType;
            this.animalName = animalName;
            this.animalWeight = animalWeight;
            this.hasShots = hasShots;
            this.isSick = isSick;
            this.isFed = isFed;
            this.kennelNumber = kennelNumber;

        }

        public virtual HSOperation HSOperations
        {
            get;
            set;
        }

        TrackingSys addAnimal = new TrackingSys();
        public  void addAnimal(TrackingSys animals)
        {

          TrackingSys.addAnimal.animals (new Animal)

            throw new System.NotImplementedException();
        }

        public virtual void removeAnimal()
        {
            throw new System.NotImplementedException();
        }


    }

}
