using System;
using System.Collections.Generic;
using System.Text;

namespace SuperShopMobile.Models
{
    public class ProductResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public object LastPurchase { get; set; }

        public object LastSale { get; set; }

        public bool IsAvailable { get; set; }

        public double Stock { get; set; }

        public UserResponse User { get; set; }

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(ImageUrl))
                {
                    return "https://8v871vkj-44361.uks1.devtunnels.ms/images/imagenotfound.png";
                }

                return $"https://8v871vkj-44361.uks1.devtunnels.ms{ImageUrl.Substring(1)}";
            }
            set
            {

            }
        }
    }
}
