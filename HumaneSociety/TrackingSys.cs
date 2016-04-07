using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class TrackingSys : IEnumerable
    {
        public List<Animal> animals;
        public List<Kennel> kennels;
        public List<Customer> customers;
        public List<FoodOp> foodOps;

        public TrackingSys()
        {
            animals = new List<Animal>();
            kennels = new List<Kennel>();
            customers = new List<Customer>();
            foodOps = new List<FoodOp>();

        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < kennels.Count; i++)
            {
                yield return kennels[i].KennelNumber;
            }

        }
    }
}
