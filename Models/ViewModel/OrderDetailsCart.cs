using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant.Models.ViewModel
{
    public class OrderDetailsCart
    {
        public List<ShoppingCart> ShoppingCart { get; set; }
        public OrderHeader  OrderHeader { get; set; }

    }
}
