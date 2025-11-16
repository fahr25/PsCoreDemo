using System;

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
			return new List<Card>
			{
				new Card { Id = 1, Name = "Birthday Card #1", CategoryId = 1 },
				new Card { Id = 2, Name = "Birthday Card #2", CategoryId = 2 },
				new Card { Id = 3, Name = "Birthday Card #3", CategoryId = 3 },
				new Card { Id = 4, Name = "Birthday Card #4", CategoryId = 1 }
			};
		}
	}
}