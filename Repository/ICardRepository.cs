using System.Collections.Generic;



namespace PsCoreDemo.Repository
{
    /// <summary>
    /// Represents the repository for managing card entities.
    /// </summary>
    public interface ICardRepository
    {

        IEnumerable<Card> GetAllCards();

    }
}
