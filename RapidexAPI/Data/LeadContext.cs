using Microsoft.EntityFrameworkCore;
using RapidexAPI.Models;

namespace RapidexAPI.Data
{
    public class LeadContext : DbContext
    {
           public LeadContext(DbContextOptions<LeadContext> opt): base(opt)
        {

        }

        public DbSet<Leads> Leads { get; set; }
    }
}
