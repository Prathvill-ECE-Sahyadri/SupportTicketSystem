using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SupportTicketSystem.Models;

namespace SupportTicketSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // 1. Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            // any seed or config code would go here
        }

        // 2. DbSet goes *outside* the constructor block
        public DbSet<Ticket> Tickets { get; set; }
    }
}
