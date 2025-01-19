using Microsoft.EntityFrameworkCore;
namespace IncidentBook.Models
{
    public class IncidentContext: DbContext
    {
        public IncidentContext(DbContextOptions<IncidentContext> options)
       : base(options)
        {
        }

        public DbSet<IncidentItem> TodoItems { get; set; } = null!;
        public DbSet<ClientItem> ClientItems { get; set; } = null!;
        public DbSet<ClosedIncidentsItem> ClosedIncidentsItems { get; set; } = null!;
        public DbSet<IncidentClassification> IncidentClassifications { get; set; } = null!;
    }
}
