using CandyStoreWebshop.Data;
using CandyStoreWebshop.Models;
using Microsoft.EntityFrameworkCore;

namespace CandyStoreWebshop.Service
{
    public class CandyRepository : ICandyRepository
    {
        private readonly AppDbContext _context;

        public CandyRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IEnumerable<Candy> GetAllCandies
        {
            get
            {
                return _context.Candies.Include(c => c.Category);
            }
        }

        public IEnumerable<Candy> GetCandiesOnSale
        {
            get
            {
                return _context.Candies.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Candy GetCandyById(int candyId)
        {
            return _context.Candies.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}
