using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
	public class EF : DbContext
	{
		public DbSet<Osoba> Osobas { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Osoba>().HasKey(o => o.Id);
		}

		public EF() : base(@"Data Source=DESKTOP-75VO5EN\DRUGISERVER;Initial Catalog=NasaBaza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
		{

		}
	}
}
