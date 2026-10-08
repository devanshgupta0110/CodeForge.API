using CodeForge.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodeForge.API.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
			
		}

		// Properties

		// We will use these properties to interact from ourt application to the database tables
		public DbSet<BlogPost> BlogPosts { get; set; }

		public DbSet<Category> Categories { get; set; }
	}
}
