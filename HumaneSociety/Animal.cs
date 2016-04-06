using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
   public abstract class Animal
    {
        private float animalWeight;
        private string animalType;
        private string animalName;
        private bool hasShots;
        private bool isSick;
        private bool isFed;
        private int animalId;
        private int kennelNumber;
        public Animal (string animalType, string animalName, float animalWeight, bool hasShots, bool isSick, bool isFed, int kennelNumber)
        
        {
            this.animalType = animalType;
            this.animalName = animalName;
            this.animalWeight = animalWeight;
            this.hasShots = hasShots;
            this.isSick = isSick;
            this.isFed = isFed;
            this.kennelNumber = kennelNumber;
            
        }


        
        public virtual string AnimalType
        {
            get
            {
                return animalType;
            }
            set
            {
                switch (value)
                {
                    case "Dog":
                        animalType = value;
                        break;
                    case "Cat":
                        animalType = value;
                        break;
                    case "Bird":
                        animalType = value;
                        break;
                    default:
                        throw new Exception("We don't accept that type of Animal");
                       
                }
                animalType = value;
            }
        }

        public virtual string AnimalName
        {
            get
            {
                return animalName;
            }
            set
            {
                animalName = value;
            }
        }

        public virtual bool HasShots
        {
            get
            {
             
                return hasShots;
            }
            set
            {
                hasShots = value;
            }
        }

        public virtual bool IsSick
        {
            get { return isSick; }
            set{ isSick = value; }
        }

        public virtual int AnimalId
        {
            get;
            set;
        }

        public virtual bool IsFed
        {
            get;
            set;
        }

        public float AnimalWeight
        {
            get;
            set;
        }


        public virtual Kennel Kennels
        {
            get;
            set;
        }

    }
}
