using GameTournament.Models;
using System.Data.Entity;

namespace GameTournament
{
	public class DatabaseContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<ApiUser> ApiUsers { get; set; }
	}
}