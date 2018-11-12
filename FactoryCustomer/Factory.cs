using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Unity;

namespace FactoryCustomer
{   
    //Design Pattern - Factory Pattern
    public static class Factory
    {
        private static IUnityContainer custs = null;

        public static CustomerBase Create(string TypeCust)
        {
            //Design Pattern - Lazy Loading
            if(custs == null)
            {
                custs = new Unity.UnityContainer();
                custs.RegisterType<CustomerBase, Customer>("Customer");
                custs.RegisterType<CustomerBase, Lead>("Lead");
            }

            //Design Pattern - Replace If with Polymorphism
            return custs.Resolve<CustomerBase>(TypeCust);
        }

    }
}
