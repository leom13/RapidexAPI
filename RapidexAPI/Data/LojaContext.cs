using Microsoft.EntityFrameworkCore;
using RapidexAPI.Models;

namespace RapidexAPI.Data
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> opt) : base(opt)
        {

        }
        public DbSet<Lojas> Lojas { get; set; }
    }
}
