using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace FactoryCustomer
{
    public static class Factory
    {
        public static CustomerBase Create(string TypeCust)
        {
            if(TypeCust == "Customer")
            {
                return new Customer();
            }
            else
            {
                return new Lead();
            }
        }

    }
}
