﻿namespace Palitra27.Web.ViewModels.Products
{
    using Palitra27.Data.Models;
    using Palitra27.Services.Mapping;

    public class ProductViewModel : IMapFrom<Product>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }
    }
}
