using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ShoppingCart
    {
        private string _id = "";
        private string _customerId;

        public string Id
        {
            get { return _id;}
            set { _id = value; }
        }

        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
    }
}