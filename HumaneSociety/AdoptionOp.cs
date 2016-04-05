using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class AdoptionOp
    {
        public virtual HSOperation HSOperations
        {
            get;
            set;
        }

        public virtual void addAnimal()
        {
            throw new System.NotImplementedException();
        }

        public virtual void removeAnimal()
        {
            throw new System.NotImplementedException();
        }
    }
}
