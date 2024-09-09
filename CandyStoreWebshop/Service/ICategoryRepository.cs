using CandyStoreWebshop.Models;

namespace CandyStoreWebshop.Service
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories {  get; }
    }
}
