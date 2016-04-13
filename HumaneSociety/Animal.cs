using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public abstract class Animal
    {
        private double animalWeight;
        private string animalType;
        private string animalName;
        private bool hasShots;
        private bool isSick;
        private bool isFed;
        private int animalId;
        private int kennelNumber;
        public Kennel kennels;
        public Animal(string animalType, string animalName, double animalWeight, bool hasShots, bool isSick, bool isFed, int kennelNumber, int animalId)

        {
            this.animalType = animalType;
            this.animalName = animalName;
            this.animalWeight = animalWeight;
            this.hasShots = hasShots;
            this.isSick = isSick;
            this.isFed = isFed;
            this.kennelNumber = kennelNumber;
            this.animalId = animalId;

        }

        public Animal()
        {
            kennels = new Kennel();
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
                    case "1":
                        animalType = "Dog";
                        break;
                    case "2":
                        animalType = "Cat";
                        break;
                    case "3":
                        animalType = "Bird";
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
            set { isSick = value; }
        }

        public virtual int AnimalId
        {
            get { return animalId; }

            set{ animalId = value; }
        }

        public virtual bool IsFed
        {
            get { return isFed; }
            set { isFed = value; }
        }

        public double AnimalWeight
        {
            get { return animalWeight; }
            set { animalWeight = value; }
        }
        public int KennelNumber
        {
            get { return kennelNumber; }
            set { kennelNumber = kennels.KennelNumber; }


            //    public virtual Kennel Kennels
            //    {
            //        get;
            //        set;
            //    }

        }
    }
}
