using Acessi_api.Models.User;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;

namespace Acessi_api.Context
{
    public class AcessiContext : DbContext
    {
        public AcessiContext(DbContextOptions<AcessiContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AcessiContext).Assembly);
        }

    }
}
