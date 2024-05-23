using Microsoft.EntityFrameworkCore;
using ShoppingCartApi.Utilities;
using ShoppingCartDTO.Product;
using ShoppingCartDTO.User;

namespace ShoppingCartApi.DAO
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<UserModel> User { get; set; }
        public DbSet<ProductModel> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = ConstantUtilities.YtraconnectionString;

            optionsBuilder.UseMySql(con, ServerVersion.AutoDetect(con));

            base.OnConfiguring(optionsBuilder);
        }
    }
}
