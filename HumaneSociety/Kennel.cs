using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
   public class Kennel
    {
        private int kennelNumber;
        private string kennelType;


        public virtual int KennelNumber
        {
            get;
            set;
        }

        public virtual string KennelType
        {
            get;
            set;
        }

        public virtual AdoptionOp AdoptionOps
        {
            get;
            set;
        }

        public virtual void houseAnimal()
        {
            throw new System.NotImplementedException();
        }

    }
}
