using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3._4.Data
{
    abstract public class Beverage
    {
        public int OrderId {  get; set; }
        public string OrderName { get; set; }
        public DateTime ExpDate { get; set; } 
        public Container Container { get; set; }
        public double SizeInOz { get; set; }
        public string BevTemp { get; set; }
        public bool IsCaffinated { get; set; }

    }
    public class Coffee : Beverage
    {
        public Roast Roast { get; set; }
        public string Flavor { get; set; }

        public Coffee(int id, string orderName,Container container, int size, string temp, bool caffine, Roast roast, string flavor)
        {
            OrderId = id;
            OrderName = orderName;
            ExpDate = DateTime.Now.AddDays(10);
            Container = container;
            SizeInOz = size;
            BevTemp = temp;
            IsCaffinated = caffine;
            Roast = roast;
            Flavor = flavor;

        }
    }
    public enum Container 
    {
        mug,
        cup,
        thermos,
        pot,
        glass

    }
    public enum Roast 
    {
        light,
        meduim,
        dark
    }
}
