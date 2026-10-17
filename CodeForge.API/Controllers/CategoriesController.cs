using CodeForge.API.Data;
using CodeForge.API.Models.Domain;
using CodeForge.API.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CodeForge.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CategoriesController : ControllerBase
	{
		private readonly ApplicationDbContext _dbContext;

		public CategoriesController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpPost]
		public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequestDto request)
		{
			var category = new Category
			{
				Id = Guid.NewGuid(),
				Name = request.Name,
				UrlHandle = request.UrlHandle
			};

			_dbContext.Categories.Add(category);
			await _dbContext.SaveChangesAsync();

			return Ok(category);
		}
	}
}


