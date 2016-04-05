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
        private int animalType;
        private string animalName;
        private bool hasShots;
        private bool isSick;
        private bool isFed;
        public virtual int AnimalType
        {
            get
            {
                return animalType;
            }
            set
            {
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
            get;
            set;
        }

        public virtual int AnimalID
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
