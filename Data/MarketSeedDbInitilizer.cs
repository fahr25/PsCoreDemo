using PsCoreDemo.Models;
using System.Linq; // Add this if not already present

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
        }
    }
}