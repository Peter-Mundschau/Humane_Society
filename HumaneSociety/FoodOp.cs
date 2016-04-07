using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class FoodOp
    {
        public virtual int dogFood
        {
            get;
            set;
        }

        public virtual int catFood
        {
            get;
            set;
        }

        public virtual int birdFood
        {
            get;
            set;
        }

        public virtual AdoptionOp AdoptionOps
        {
            get;
            set;
        }

        public virtual void feedAnimals()
        {
            throw new System.NotImplementedException();
        }
    }
}
