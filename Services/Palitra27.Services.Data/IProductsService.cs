﻿namespace Palitra27.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Http;
    using Palitra27.Data.Models;
    using Palitra27.Web.ViewModels.Products;

    public interface IProductsService
    {
        Product Create(CreateProductBindingModel model);

        Product Create(CreateProductBindingModel model, IFormFile Image);

        Product FindProductById(string id);

        IQueryable<Category> FindAllCategories();

        IQueryable<ProductBrand> FindAllBrands();

        Product EditProduct(ProductEditBindingModel model);

        Review AddReview(AddReviewBindingModel model, string userId);

        Product EditDescription(EditDescriptionBindingModel model);

        Product EditSpecifications(EditSpecificationsBindingModel model);

        Product GetProductById(string id);

        IEnumerable<Product> GetAllProducts();

        List<Product> FindAllProductsByQuery(string query);

        //void AddImageUrls(string id, IEnumerable<string> imageUrls);
    }
}
