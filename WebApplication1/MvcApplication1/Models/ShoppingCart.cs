using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ShoppingCart
    {
        private string _id = "";
        private string _customerId;
        private decimal _grossTotal;
        private decimal _nettTotal;
        private decimal _taxTotal;

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

        public decimal GrossTotal
        {
            get { return _grossTotal; }
            set { _grossTotal = value; }
        }

        public decimal NettTotal
        {
            get { return _nettTotal; }
            set { _nettTotal = value; }
        }

        public decimal TaxTotal
        {
            get { return _taxTotal; }
            set { _taxTotal = value; }
        }

        private Collection<ShoppingCartLineItem> _lineItems;

        public Collection<ShoppingCartLineItem> LineItems
        {
            get { return _lineItems; }
            set { _lineItems = value; }
        }
    }
}