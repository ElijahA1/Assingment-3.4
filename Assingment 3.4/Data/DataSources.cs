using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_3._4.Data
{
    public static class DataSources
    {
        public static Queue<Coffee> orders = new Queue<Coffee> ();

        public static Queue<Coffee> GetOrders()
        {
            orders = new Queue<Coffee>();
            orders.Enqueue(new Coffee(1, "Elijah", Container.cup, 16, "hot", true, Roast.dark, "vanilla"));
            orders.Enqueue(new Coffee(2, "John",  Container.cup, 8, "hot", true, Roast.dark, "cinnamon"));
            orders.Enqueue(new Coffee(3, "Smith",  Container.cup, 8, "cold", true, Roast.light, "vanilla"));
            orders.Enqueue(new Coffee(4, "Jane",  Container.cup, 16, "iced", true, Roast.meduim, "hazelnut"));
            orders.Enqueue(new Coffee(5, "Steve", Container.mug,8, "hot", true, Roast.dark, "none"));

            return orders;
        }

    }
}
