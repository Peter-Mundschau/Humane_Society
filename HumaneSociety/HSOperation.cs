using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
   public class HSOperation
    {
        public virtual string firstName
        {
            get;
            set;
        }

        public virtual string lastName
        {
            get;
            set;
        }

        public virtual void Operation1()
        {
            throw new System.NotImplementedException();
        }
    }
}
