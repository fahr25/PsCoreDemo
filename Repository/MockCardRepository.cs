using System.Collections.Generic;
using PsCoreDemo.Models;

namespace PsCoreDemo.Repository
{
    /// <summary>
    /// A mock implementation of the ICardRepository interface for testing purposes.
    /// </summary>
    public class MockCardRepository : ICardRepository
    {
        /// <summary>
        /// Retrieves all cards from the mock repository.
        /// </summary>
        /// <returns>A collection of all cards.</returns>
        public IEnumerable<Card> GetAllCards()
        {
			// Returning a hardcoded list of cards for development/testing purposes.
			// In a real application, this data would come from a database or external source.
            return new List<Card>
            {
                new Card
                {
                    Id = 1,
                    Name = "Happy Birthday - Confetti",
                    Description = "A colorful confetti birthday card with gold foil accents.",
                    Image = "/images/cards/confetti.svg",
                    Points = 1,
                    Inventory = 120,
                    MinAge = 3,
                    MaxAge = 18,
                    Categories = new List<Category>
                    {
                        new Category { Id = 1, Name = "Birthday Card" }
                    },
                    Notes = "Popular choice for kids and adults."
                },
                new Card
                {
                    Id = 2,
                    Name = "Handmade Floral",
                    Description = "Handmade card with pressed flowers. Eco-friendly materials.",
                    Image = "/images/cards/floral.svg",
                    Points = 1,
                    Inventory = 40,
                    MinAge = 12,
                    MaxAge = 18,
                    Categories = new List<Category>
                    {
                        new Category { Id = 1, Name = "Birthday Card" },
                        new Category { Id = 2, Name = "Book" } // example of multi-category
                    },
                    Notes = "Limited stock; handle with care."
                },
                new Card
                {
                    Id = 3,
                    Name = "Kids' Animal Parade",
                    Description = "Bright and playful animal parade card for young children.",
                    Image = "/images/cards/animal_parade.svg",
                    Points = 5,
                    Inventory = 200,
                    MinAge = 0,
                    MaxAge = 10,
                    Categories = new List<Category>
                    {
                        new Category { Id = 3, Name = "Toys" }
                    },
                    Notes = "Includes stickers inside."
                },
                new Card
                {
                    Id = 4,
                    Name = "Elegant Script Birthday",
                    Description = "Minimalist card with elegant script and embossed finish.",
                    Image = "/images/cards/elegant_script.svg",
                    Points = 2,
                    Inventory = 75,
                    MinAge = 18,
                    MaxAge = 99,
                    Categories = new List<Category>
                    {
                        new Category { Id = 1, Name = "Birthday Card" }
                    },
                    Notes = "Great for formal occasions."
                }
            };
        }
    }
}