using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
   public abstract class People
    {
        private string firstName;
        private string lastName;
        public virtual string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public virtual string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public virtual HSOperation HSOperations
        {
            get;
            set;
        }

    }
}
