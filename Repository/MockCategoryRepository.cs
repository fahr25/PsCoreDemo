using System;
using System.Collections.Generic;
using PsCoreDemo.Models;

namespace PsCoreDemo.Repository
{
	/// <summary>
	/// Mock implementation of <see cref="ICategoryRepository"/> for testing/data seeding
	/// </summary>
	public class MockCategoryRepository : ICategoryRepository
	{
		public IEnumerable<Category> GetAllCategories()
		{
			return new List<Category>
			{
				new Category { Id = 1, Name = "Birthday Card" },
				new Category { Id = 2, Name = "Book" },
				new Category { Id = 3, Name = "Toys" }
			};
		}
	}
}
