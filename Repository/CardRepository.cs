using PsCoreDemo.Data;
using PsCoreDemo.Models;

namespace PsCoreDemo.Repository;

public class CardRepository : ICardRepository
{
    private readonly MarketShopDbContext _marketShopDbContext;
    
    public CardRepository(MarketShopDbContext marketShopDbContext)
    {
        _marketShopDbContext = marketShopDbContext;
    }

    public IEnumerable<Card> GetAllCards()
    {
        // Return cards ordered by Name descending
        return _marketShopDbContext.Cards.OrderByDescending(c => c.Name);
    }

    public Card GetCardById(int cardId)
    {
        var card = _marketShopDbContext.Cards.FirstOrDefault(c => c.Id == cardId);
        if (card == null)
            throw new InvalidOperationException($"Card with Id {cardId} not found.");
        return card;
    }
    
}
