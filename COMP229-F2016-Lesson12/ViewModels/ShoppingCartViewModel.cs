using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using COMP229_F2016_Lesson12.Models;

namespace COMP229_F2016_Lesson12.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}