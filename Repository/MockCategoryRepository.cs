using System;

/// <summary>
/// Summary description for Class1
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
    }>>
}
