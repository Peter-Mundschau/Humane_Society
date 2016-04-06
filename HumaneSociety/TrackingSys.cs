using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
     public class TrackingSys
    {
        public List<Animal> animals;
         List<Kennel> kennels;
         List<Customer> customers;
         List<FoodOp> foodOps;

        public TrackingSys()
        {
            animals = new List<Animal>();
            kennels = new List<Kennel>();
            customers = new List<Customer>();
            foodOps = new List<FoodOp>();


        }
    }
}
