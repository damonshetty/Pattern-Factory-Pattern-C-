using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace FactoryCustomer
{   
    //Design Pattern - Factory Pattern
    public static class Factory
    {
        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();

        public static CustomerBase Create(string TypeCust)
        {
            //Design Pattern - Lazy Loading
            if(custs.Count == 0)
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }

            //Design Pattern - Replace If with Polymorphism
            return custs[TypeCust];
        }

    }
}
