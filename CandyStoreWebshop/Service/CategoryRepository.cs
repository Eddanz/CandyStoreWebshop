using CandyStoreWebshop.Data;
using CandyStoreWebshop.Models;

namespace CandyStoreWebshop.Service
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IEnumerable<Category> GetAllCategories => _context.Categories;
    }
}
