using Humanizer.Localisation;

namespace XWEARShopUI
{ 
    public interface ICatalogRepository
    {
        Task<IEnumerable<Product>> GetProducts(string sTerm = "", int genreId = 0);
        Task<IEnumerable<Category>> Categories();
    }
}
