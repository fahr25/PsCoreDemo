using PsCoreDemo.Models;
using PsCoreDemo.Repository;
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
                // adds mock categories from the mock repository
                var mockCategoryRepo = new MockCategoryRepository();
                var categories = mockCategoryRepo.GetAllCategories();
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }

            // Seed cards if none exist
            if (!context.Cards.Any())
            {
                // adds mock cards from the mock repository
                var mockCardRepo = new MockCardRepository();
                var cards = mockCardRepo.GetAllCards();
                
                // Replace mock Categories with existing ones to avoid tracking conflicts
                var existingCategories = context.Categories.ToList();
                foreach (var card in cards)
                {
                    card.Categories = existingCategories
                        .Where(c => card.Categories.Any(mc => mc.Id == c.Id))
                        .ToList();
                }
                
                context.Cards.AddRange(cards);
                context.SaveChanges();
            }
        }
    }
}