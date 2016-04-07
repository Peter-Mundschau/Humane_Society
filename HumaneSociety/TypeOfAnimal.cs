using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class TypeOfAnimal 
    
    {
        public TypeOfAnimal typeOfAnimal;

        public virtual bool dog
        {
            get { return true; }
            set { dog = value; }
        }

        public virtual bool cat
        {
            get { return true; }
            set { cat = value; }
        }

        public virtual bool bird
        {
            get { return true; }
            set { bird = value; }
        }

        public void  Dog()
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
