﻿namespace Palitra27.Web.MappingConfigurations
{
    using System;

    using AutoMapper;
    using Palitra27.Data.Models;
    using Palitra27.Data.Models.DtoModels.ApplicationUserDTO;
    using Palitra27.Data.Models.DtoModels.Brand;
    using Palitra27.Data.Models.DtoModels.Category;
    using Palitra27.Data.Models.DtoModels.FavouriteList;
    using Palitra27.Data.Models.DtoModels.Order;
    using Palitra27.Data.Models.DtoModels.Product;
    using Palitra27.Data.Models.DtoModels.Review;
    using Palitra27.Data.Models.DtoModels.ShoppingCart;
    using Palitra27.Data.Models.DtoModels.ShoppingCartProduct;
    using Palitra27.Data.Models.Enums;
    using Palitra27.Web.ViewModels.FavouriteList;
    using Palitra27.Web.ViewModels.Orders;
    using Palitra27.Web.ViewModels.Products;
    using Palitra27.Web.ViewModels.ShoppingCart;

    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            this.CreateMap<Category, CategoryDTO>();
            this.CreateMap<CategoryDTO, Category>();

            this.CreateMap<Brand, BrandDTO>();
            this.CreateMap<BrandDTO, Brand>();

            this.CreateMap<Order, OrderDTO>();
            this.CreateMap<OrderDTO, Order>();

            this.CreateMap<Review, ReviewDTO>();
            this.CreateMap<ReviewDTO, Review>();

            this.CreateMap<ShoppingCartProductDTO, ShoppingCartProduct>();
            this.CreateMap<ShoppingCartProduct, ShoppingCartProductDTO>();

            this.CreateMap<ShoppingCart, ShoppingCartDTO>();
            this.CreateMap<ShoppingCartDTO, ShoppingCart>();

            this.CreateMap<ApplicationUser, ApplicationUserDTO>();

            this.CreateMap<FavouriteList, FavouriteListDTO>();

            this.CreateMap<ProductDTO, ProductViewModel>();
            this.CreateMap<Product, ShoppingCartProductsViewModel>();
            this.CreateMap<ProductEditBindingModel, ProductDTO>();
            this.CreateMap<ProductDTO, ShoppingCartProductsViewModel>();

            this.CreateMap<FavouriteProduct, FavouriteProductViewModel>()
                .ForMember(x => x.Name, y => y.MapFrom(src => src.Product.Name))
                .ForMember(x => x.Id, y => y.MapFrom(src => src.ProductId))
                .ForMember(x => x.Image, y => y.MapFrom(src => src.Product.Image))
                .ForMember(x => x.Price, y => y.MapFrom(src => src.Product.Price));

            this.CreateMap<ApplicationUserDTO, Order>()
              .ForMember(x => x.UserId, y => y.MapFrom(src => src.Id))
              .ForMember(x => x.FirstName, y => y.Ignore())
              .ForMember(x => x.LastName, y => y.Ignore())
              .ForMember(x => x.PhoneNumber, y => y.Ignore());

            this.CreateMap<Country, Order>()
             .ForMember(x => x.CountryId, y => y.MapFrom(src => src.Id))
             .ForMember(x => x.Country, y => y.MapFrom(src => src));

            this.CreateMap<AddReviewBindingModel, Review>()
                .ForMember(x => x.DateOfCreation, y => y.MapFrom(src => DateTime.Now));

            this.CreateMap<OrderProduct, ShoppingCartProductsViewModel>()
                .ForMember(x => x.Name, y => y.MapFrom(src => src.Product.Name))
                .ForMember(x => x.Id, y => y.MapFrom(src => src.Product.Id))
                .ForMember(x => x.Image, y => y.MapFrom(src => src.Product.Image))
                .ForMember(x => x.Price, y => y.MapFrom(src => src.Price))
                .ForMember(x => x.Quantity, y => y.MapFrom(src => src.Quantity))
                .ForMember(x => x.TotalPrice, y => y.MapFrom(src => src.Product.Price));

            this.CreateMap<Order, OrderCreateBindingModel>()
                .ForMember(x => x.Country, y => y.MapFrom(src => src.Country.Name));

            this.CreateMap<OrderDTO, OrderCreateBindingModel>()
                .ForMember(x => x.Country, y => y.MapFrom(src => src.Country.Name))
                .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.Status));

            this.CreateMap<OrderCreateBindingModel, Order>()
               .ForMember(x => x.PhoneNumber, y => y.MapFrom(src => src.PhoneNumber))
               .ForMember(x => x.Country, y => y.Ignore())
               .ForMember(x => x.CountryId, y => y.Ignore())
               .ForMember(x => x.PaymentStatus, y => y.MapFrom(src => PaymentStatus.Unpaid))
               .ForMember(x => x.OrderDate, y => y.MapFrom(src => DateTime.UtcNow))
               .ForMember(x => x.Status, y => y.MapFrom(src => OrderStatus.Processed))
               .ForMember(x => x.DeliveryPrice, y => y.MapFrom(src => src.DeliveryPrice))
               .ForMember(x => x.DeliveryDate, y => y.MapFrom(src => DateTime.UtcNow.AddDays(7)))
               .ForMember(x => x.Id, y => y.Ignore());

            this.CreateMap<ShoppingCartProductDTO, ShoppingCartProductsViewModel>()
                .ForMember(x => x.TotalPrice, y => y.MapFrom(src => src.Quantity * src.Product.Price))
                .ForMember(x => x.Price, y => y.MapFrom(src => src.Product.Price))
                .ForMember(x => x.Name, y => y.MapFrom(src => src.Product.Name))
                .ForMember(x => x.Id, y => y.MapFrom(src => src.Product.Id))
                .ForMember(x => x.Image, y => y.MapFrom(src => src.Product.Image));

            this.CreateMap<ProductDTO, Product>()
                .ForMember(x => x.Category, y => y.MapFrom(c => c.Category))
                .ForMember(x => x.Brand, y => y.MapFrom(c => c.Brand))
                .ForMember(x => x.Reviews, y => y.MapFrom(c => c.Reviews));

            this.CreateMap<Product, ProductDTO>()
                        .ForMember(x => x.Category, y => y.MapFrom(c => c.Category))
                        .ForMember(x => x.Brand, y => y.MapFrom(c => c.Brand))
                .ForMember(x => x.Reviews, y => y.MapFrom(c => c.Reviews));

            this.CreateMap<ProductDTO, ProductInfoViewModel>()
                .ForMember(x => x.Category, y => y.MapFrom(c => c.Category.Name))
                .ForMember(x => x.Brand, y => y.MapFrom(c => c.Brand.Name))
                .ForMember(x => x.Width, y => y.MapFrom(c => c.Width == 0 ? 0 : Math.Round(c.Width)))
                .ForMember(x => x.Depth, y => y.MapFrom(c => c.Depth == 0 ? 0 : Math.Round(c.Depth)))
                .ForMember(x => x.Weight, y => y.MapFrom(c => c.Weight == 0 ? 0 : Math.Round(c.Weight)))
                .ForMember(x => x.Height, y => y.MapFrom(c => c.Height == 0 ? 0 : Math.Round(c.Height)));

            this.CreateMap<Product, ProductInfoViewModel>()
                .ForMember(x => x.Category, y => y.MapFrom(c => c.Category.Name))
                .ForMember(x => x.Brand, y => y.MapFrom(c => c.Brand.Name));
        }
    }
}
