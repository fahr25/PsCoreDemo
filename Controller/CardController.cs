using Microsoft.AspNetCore.Mvc;
using PsCoreDemo.Repository; 
using PsCoreDemo.ViewModels;

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
            // Create an instance of CardListViewModel to encapsulate the data for the view.
            CardListViewModel cardListViewModel = new CardListViewModel()
            {
                // This example uses mock data from mock card repository.
                // Cards = _cardRepository.GetAllCards(),
                // CurrentCategory = "Birthday Cards"

                // This example uses data from the database via the CardRepository.
                Cards = _cardRepository.GetAllCards(),
                CurrentCategory = "Birthday Cards"
            };

            return View(cardListViewModel);
        }

    }   
}