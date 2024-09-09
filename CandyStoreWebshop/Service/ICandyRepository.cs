using CandyStoreWebshop.Models;

namespace CandyStoreWebshop.Service
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandies {  get; }
        IEnumerable<Candy> GetCandiesOnSale {  get; }
        Candy GetCandyById(int candyId);
    }
}
