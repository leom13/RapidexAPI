using Microsoft.EntityFrameworkCore;
using RapidexAPI.Models;

namespace RapidexAPI.Data
{
    public class VeiculoContext : DbContext
    {
        public VeiculoContext(DbContextOptions<VeiculoContext> opt) : base(opt)
        {

        }
        public DbSet<Veiculos> Veiculos { get; set; }
    }
}
