using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class ShoppingCartController : Controller
    {
        //
        // GET: /ShoppingCart/

        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart()
            {
                Id = Guid.NewGuid().ToString(),
                CustomerId = "C12345",
                GrossTotal = 1000,
                TaxTotal = 200,
                NettTotal = 1200
            };
            return View(cart);
        }

    }
}
