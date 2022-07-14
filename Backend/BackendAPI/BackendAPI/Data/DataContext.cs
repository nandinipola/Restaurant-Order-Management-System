using BackendAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendAPI.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<FoodItems> FoodItems => Set<FoodItems>();

        public DbSet<Orders> Orders => Set<Orders>();

        public DbSet<Users> Users => Set<Users>();
    }
}
