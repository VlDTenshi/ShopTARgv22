using Microsoft.EntityFrameworkCore;

namespace Shop.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options) 
		{
		}

		public DbSet<CRMApp> cRMApps { get; set; }
	}
}
