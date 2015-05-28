using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ShoppingCartLineItem
    {
        private string _productId;
        public string ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
    }
}