using Microsoft.AspNetCore.Mvc;
using ProductOfferService.Models;

namespace ProductOfferService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OfferServiceController : ControllerBase
    {
        
        private OfferService _offerService = new OfferService();
        public OfferServiceController()
        {
        }

        [HttpGet(Name = "GetAllProducts")]
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return _offerService.GetAllProducts();
        }

        [HttpGet(Name = "GetTodaysOffers")]
        public async Task<Dictionary<string, List<Product>>> GetTodaysOffers()
        {
            var result = _offerService.GetTodaysOffers();
            return result;
        }

        [HttpPost(Name = "AddProduct")]
        public async void AddProduct(Product newProduct)
        {
            _offerService.AddProduct(newProduct);
        }
    }
}