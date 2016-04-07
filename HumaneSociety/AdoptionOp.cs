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


        public virtual void addAnimal(Animal animals)
        {

            kennels.Add(new Kennel(animals));


            throw new System.NotImplementedException();
        }

        public virtual void removeAnimal()
        {
            throw new System.NotImplementedException();
        }


    }

}
