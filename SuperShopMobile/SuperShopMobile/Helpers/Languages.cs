﻿using SuperShopMobile.Interfaces;
using SuperShopMobile.Resources;
using System.Globalization;
using Xamarin.Forms;

namespace SuperShopMobile.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            CultureInfo ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            Culture = ci.Name;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }
        public static string Culture { get; set; }
        public static string Accept => Resource.Accept;
        public static string ConnectionError => Resource.ConnectionError;
        public static string Error => Resource.Error;
        public static string Name => Resource.Name;
        public static string Product => Resource.Product;
        public static string Products => Resource.Products;
        public static string Price => Resource.Price;
        public static string AddToCart => Resource.AddToCart;
        public static string Loading => Resource.Loading;
        public static string SearchProduct => Resource.SearchProduct;
        public static string IsAvaible => Resource.IsAvailable;
        public static string Stock => Resource.Stock;

        public static string Login => Resource.Login;

        public static string Modifyuser => Resource.Modifyuser;

        public static string ShowPurchaseHistory => Resource.ShowPurchaseHistory;
        public static string ShowShoppingCart => Resource.ShowShoppingCart;
    }
}

