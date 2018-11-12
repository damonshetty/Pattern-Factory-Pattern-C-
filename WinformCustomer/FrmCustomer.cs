using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using FactoryCustomer;

namespace WinformCustomer
{
    //UI layer to consume business layer
    public class FrmCustomer
    {
        private CustomerBase cust = null;

        public FrmCustomer()
        {
            //This would be a UI where a type of customer is chosen
            cust = Factory.Create("Text of button clicked");
        }
    }
}
