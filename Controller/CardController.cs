using Microsoft.AspNetCore.Mvc;
using PsCoreDemo.Repository;   

namespace PsCoreDemo.Controllers
{
    // Controller type is part of MVC (Model-View-Controller) pattern and provides essential functionality for handling HTTP requests and generating responses.
    public class CardController : Controller
    {
        // Private fields to hold references to the injected repository interfaces.
        private readonly ICardRepository _cardRepository;
        private readonly ICategoryRepository _categoryRepository;

        // Using Constructor Injection to inject dependencies into the controller.
        public CardController(ICardRepository cardRepository, ICategoryRepository categoryRepository)
        {
            _cardRepository = cardRepository;
            _categoryRepository = categoryRepository;
        }

        // Action method to handle HTTP GET requests for listing all birthday cards.
        public IActionResult List()
        {
            return View(_cardRepository.GetAllCards());
        }

    }   
}