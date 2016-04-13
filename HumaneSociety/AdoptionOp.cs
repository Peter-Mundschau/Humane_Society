using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class AdoptionOp : TrackingSys
    {
        

        public virtual HSOperation HSOperations
        {
            get;
            set;
        }


        //public virtual string addAnimal(Animal animalType)
        //{

        //    kennels.Add(new Kennel(animalType));


        //    throw new System.NotImplementedException();
        //}

        public virtual void removeAnimal()
        {
            throw new System.NotImplementedException();
        }


    }

}
