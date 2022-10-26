using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Agenda_App.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
					public DbSet<Models.Contact> Contact { get; set; }
					public DbSet<Models.Schedule> Schedule { get; set; }
	
	}
}