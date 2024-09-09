using CandyStoreWebshop.Service;
using CandyStoreWebshop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CandyStoreWebshop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = _candyRepository.GetAllCandies;
            candyListViewModel.CurrentCategory = "Best Sellers";
            return View(candyListViewModel);
        }
    }
}
