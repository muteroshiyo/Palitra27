﻿namespace Palitra27.Web.ViewModels.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Palitra27.Web.ViewModels.ShoppingCart;

    public class OrderShoppingCartViewModel
    {
        public string Id { get; set; }
        
        public OrderCreateViewModel OrderCreateViewModel { get; set; }

        public IList<ShoppingCartProductsViewModel> ShoppingCartProductsViewModels { get; set; }

        public List<string> Countries { get; set; }
    }
}
