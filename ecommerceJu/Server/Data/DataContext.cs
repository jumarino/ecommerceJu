using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ecommerceJu.Server.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "Nespresso",
					Description = "Nespresso capsules were sold exclusively by Nespresso while the machines were under patent, and are significantly more expensive than an equivalent quantity of loose ground coffee.",
					ImageUrl = "",
					Price = 19.99m
				},


			new Product
			{
				Id = 2,
				Title = "Dolce Gusto",
				Description = "Nescafé Dolce Gusto coffee capsules come in a variety of pack sizes which contain 12, 16 or 30 capsules. 12 pod boxes can make between 6 – 12 cups and 30 pod boxes are sufficient enough for between 15 – 30 cups, depending on the type of beverage.",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ab/Logo_Nescaf%C3%A9_dolce_gusto.png",
				Price = 29.99m
			},

			new Product
			{
				Id = 3,
				Title = "Starbucks",
				Description = "Starbucks Verismo became publicly available, consisting of a line of coffee makers that brew espresso and regular chocolate from coffee capsules, a type of pre-apportioned single-use container of ground coffee and flavourings utilizing the K-Fee pod system.",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/0/0f/Starbucks_Corporation_Logo_2011.svg.png",
				Price = 39.99m

			});
			
		}


		public DbSet<Product> Products { get; set; }
    }
}
