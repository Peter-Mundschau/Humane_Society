using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
   public class Kennel 
    {
        private int kennelNumber;
        //public Animal animals;
        //public Kennel kennels;
        public int i;
        public Kennel()
        {
            
            kennelNumber = KennelNumber;         
            
        }
        //public Kennel(Animal animalType)
        //{
        //    animals = AdoptionOps.animals;
        //}

        public virtual int KennelNumber
        {
            get
            {
                return kennelNumber;
                
            }
            set
            {
                
                kennelNumber = value;
            }
        }



        public virtual AdoptionOp AdoptionOps { get; set;}

        public virtual void houseAnimal()
        {
            
            throw new System.NotImplementedException();
        }


        
    }
}
