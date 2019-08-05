﻿namespace Palitra27.Web.ViewModels.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OrderAdressViewModel
    {
        public string Id { get; set; }

        public string Street { get; set; }

        public string Description { get; set; }

        public string CityName { get; set; }

        public string CityPostcode { get; set; }
    }
}