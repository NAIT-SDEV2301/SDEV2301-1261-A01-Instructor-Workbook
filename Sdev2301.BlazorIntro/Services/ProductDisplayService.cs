using Sdev2301.BlazorIntro.Models;

namespace Sdev2301.BlazorIntro.Services
{
    public class ProductDisplayService
    {
        public string GetStatus(Product product)
        {
            return product.IsActive ? "Active" : "Inactive";
        }

        public string GetSummary(Product product)
        {
            return $"{product.Sku} - {product.Name} ({product.Price:C})";
        }

        public string GetPriceMessage(Product product)
        {
            return product.Price >= 100m
                ? "Premium product"
                : "Standard product";
        }
    }
}
