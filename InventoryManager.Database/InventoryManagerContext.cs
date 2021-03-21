using InventoryManager.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Database
{
    public class InventoryManagerContext : DbContext
    {
        public virtual DbSet<Pallet> Pallets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured)
            {
                return;
            }

            optionsBuilder.UseSqlServer("Server=idp4t033zegwar.cwv8xjctaxvk.sa-east-1.rds.amazonaws.com;Database=InventoryManagerDB;User Id=yourusername;Password=yourusername");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
