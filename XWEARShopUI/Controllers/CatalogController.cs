using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using XWEARShopUI;
using XWEARShopUI.Controllers;

namespace WebXWEAR.Controllers
{
	public class CatalogController : Controller
	{
        private readonly ICatalogRepository _catalogRepository;
        public CatalogController(ICatalogRepository catalogRepository)
        {
			_catalogRepository = catalogRepository;
        }

        public async Task<IActionResult> Index(string sTerm="", int categoryId=0)
		{
            IEnumerable<Product> products = await _catalogRepository.GetProducts(sTerm, categoryId);
            IEnumerable<Category> categories = await _catalogRepository.Categories();
            ProductDisplayModel bookModel = new ProductDisplayModel
            {
                Products = products,
                Categories = categories,
                STerm = sTerm,
                CategoryId = categoryId
            };
            return View(bookModel);
		}
	}
}
