using Microsoft.EntityFrameworkCore;
using RankingAppNET6.Models;

namespace RankingAppNET6.Data
{
    public class DataContext : DbContext
    {


        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ItemModel> ItemModels => Set<ItemModel>();
    }

}

