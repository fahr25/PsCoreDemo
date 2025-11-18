using PsCoreDemo.Models;
using System.Linq;

namespace PsCoreDemo.Data
{
    public static class MarketSeedDbInitializer
    {
        public static void Seed(MarketShopDbContext context)
        {
            // Ensure the database is created (if not using migrations)
            context.Database.EnsureCreated();

            // Seed categories if none exist
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Id = 1, Name = "Birthday Card" },
                    new Category { Id = 2, Name = "Book" },
                    new Category { Id = 3, Name = "Toys" }
                };
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            // Seed cards if none exist
            if (!context.Cards.Any())
            {
                // Get existing categories to link to cards
                var existingCategories = context.Categories.ToList();

                var cards = new List<Card>
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
                        Categories = existingCategories.Where(c => c.Id == 1).ToList(), // Link to "Birthday Card"
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
                        Categories = existingCategories.Where(c => c.Id == 1 || c.Id == 2).ToList(), // Link to "Birthday Card" and "Book"
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
                        Categories = existingCategories.Where(c => c.Id == 3).ToList(), // Link to "Toys"
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
                        Categories = existingCategories.Where(c => c.Id == 1).ToList(), // Link to "Birthday Card"
                        Notes = "Great for formal occasions."
                    },
                    new Card
                    {
                        Id = 5,
                        Name = "Pop-Up Surprise",
                        Description = "Interactive pop-up card with 3D elements and a pull-tab surprise.",
                        Image = "/images/cards/popup_surprise.svg",
                        Points = 3,
                        Inventory = 30,
                        MinAge = 6,
                        MaxAge = 99,
                        Categories = existingCategories.Where(c => c.Id == 1).ToList(), // Link to "Birthday Card"
                        Notes = "Fragile – keep flat."
                    },
                    new Card
                    {
                        Id = 6,
                        Name = "Thank You Watercolor",
                        Description = "Soft watercolor thank-you card with hand-painted look and subtle gold accents.",
                        Image = "/images/cards/thank_you_watercolor.svg",
                        Points = 1,
                        Inventory = 85,
                        MinAge = 0,
                        MaxAge = 99,
                        Categories = existingCategories.Where(c => c.Id == 2).ToList(), // Link to "Book"
                        Notes = "Pairs well with ribbon or small gifts."
                    }
                };

                context.Cards.AddRange(cards);
                context.SaveChanges();
            }

            // Seed books if none exist
            if (!context.Books.Any())
            {
                // Get existing categories to link to books
                var existingCategories = context.Categories.ToList();

                var books = new List<Book>
                {
                    new Book
                    {
                        Id = 1,
                        Name = "The Great Adventure",
                        Description = "A thrilling tale of exploration and discovery in a fantasy world.",
                        Image = "/images/books/book1.png",
                        Points = 10,
                        Inventory = 50,
                        MinAge = 8,
                        MaxAge = 99,
                        Author = "Jane Doe",
                        Genre = "Fantasy",
                        Categories = existingCategories.Where(c => c.Id == 2).ToList() // Link to "Book"
                    },
                    new Book
                    {
                        Id = 2,
                        Name = "Mystery of the Lost City",
                        Description = "Solve puzzles and uncover secrets in this engaging mystery novel.",
                        Image = "/images/books/book2.png",
                        Points = 15,
                        Inventory = 30,
                        MinAge = 10,
                        MaxAge = 99,
                        Author = "John Smith",
                        Genre = "Mystery",
                        Categories = existingCategories.Where(c => c.Id == 2).ToList()
                    },
                    new Book
                    {
                        Id = 3,
                        Name = "Coding for Kids",
                        Description = "An introductory guide to programming with fun projects.",
                        Image = "/images/books/book3.png",
                        Points = 20,
                        Inventory = 75,
                        MinAge = 6,
                        MaxAge = 14,
                        Author = "Tech Guru",
                        Genre = "Educational",
                        Categories = existingCategories.Where(c => c.Id == 2 || c.Id == 3).ToList() // Link to "Book" and "Toys"
                    },
                    new Book
                    {
                        Id = 4,
                        Name = "Space Explorers",
                        Description = "Journey through the stars with astronauts and aliens.",
                        Image = "/images/books/book4.png",
                        Points = 12,
                        Inventory = 40,
                        MinAge = 5,
                        MaxAge = 99,
                        Author = "Astronaut Alice",
                        Genre = "Science Fiction",
                        Categories = existingCategories.Where(c => c.Id == 2).ToList()
                    },
                    new Book
                    {
                        Id = 5,
                        Name = "Animal Friends",
                        Description = "Heartwarming stories about animals and their adventures.",
                        Image = "/images/books/book5.png",
                        Points = 8,
                        Inventory = 100,
                        MinAge = 3,
                        MaxAge = 10,
                        Author = "Nature Lover",
                        Genre = "Children's",
                        Categories = existingCategories.Where(c => c.Id == 2 || c.Id == 3).ToList()
                    },
                    new Book
                    {
                        Id = 6,
                        Name = "History of Heroes",
                        Description = "Learn about legendary figures and their epic deeds.",
                        Image = "/images/books/book6.png",
                        Points = 18,
                        Inventory = 25,
                        MinAge = 12,
                        MaxAge = 99,
                        Author = "Historian Hank",
                        Genre = "History",
                        Categories = existingCategories.Where(c => c.Id == 2).ToList()
                    },
                    new Book
                    {
                        Id = 7,
                        Name = "Magical Tales",
                        Description = "Enchanting stories filled with magic and wonder.",
                        Image = "/images/books/book7.png",
                        Points = 14,
                        Inventory = 60,
                        MinAge = 7,
                        MaxAge = 99,
                        Author = "Wizard Wendy",
                        Genre = "Fantasy",
                        Categories = existingCategories.Where(c => c.Id == 2).ToList()
                    },
                    new Book
                    {
                        Id = 8,
                        Name = "Eco-Warriors",
                        Description = "Inspiring tales of environmental heroes saving the planet.",
                        Image = "/images/books/book8.png",
                        Points = 16,
                        Inventory = 35,
                        MinAge = 9,
                        MaxAge = 99,
                        Author = "Green Guardian",
                        Genre = "Non-Fiction",
                        Categories = existingCategories.Where(c => c.Id == 2).ToList()
                    },
                    new Book
                    {
                        Id = 9,
                        Name = "Puzzle Palace",
                        Description = "A collection of brain-teasing puzzles and riddles.",
                        Image = "/images/books/book9.png",
                        Points = 11,
                        Inventory = 80,
                        MinAge = 6,
                        MaxAge = 99,
                        Author = "Puzzle Master",
                        Genre = "Puzzle",
                        Categories = existingCategories.Where(c => c.Id == 2 || c.Id == 3).ToList()
                    },
                    new Book
                    {
                        Id = 10,
                        Name = "Dream Big",
                        Description = "Motivational stories to inspire young dreamers.",
                        Image = "/images/books/book10.png",
                        Points = 13,
                        Inventory = 45,
                        MinAge = 4,
                        MaxAge = 99,
                        Author = "Dreamer Dave",
                        Genre = "Inspirational",
                        Categories = existingCategories.Where(c => c.Id == 2).ToList()
                    }
                };

                context.Books.AddRange(books);
                context.SaveChanges();
            }
        }
    }
}