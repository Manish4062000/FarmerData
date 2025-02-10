using FarmerDatas.API.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace FarmerDatas.API.Data
{
    public class FarmerDataDbContext:DbContext
    {
        public FarmerDataDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Farmer> Farmers { get; set; }
    }
}
