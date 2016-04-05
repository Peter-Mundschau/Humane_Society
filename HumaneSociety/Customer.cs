using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Customer : People
    {
        private int customerId;

        public int CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
            }
        }

        public void adoptAnimal()
        {
            throw new System.NotImplementedException();
        }
    }
}
