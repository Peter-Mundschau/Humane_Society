using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class TypeOfAnimal : Animal
    
    {


        public virtual bool dog
        {
            get ; 
            set;
        }

        public virtual bool cat
        {
            get;
            set;
        }

        public virtual bool bird
        {
            get;
            set;
        }

        public void Dog()
        {
            

        }


        public void Cat()
        {


        }

        public void Bird()
        {


        }


    }
}
