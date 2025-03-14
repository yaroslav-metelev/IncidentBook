using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncidentBook.Models
{
    public class IncidentItem
    {
        [Key]
        public long Id { get; set; }
        public DateTime DateTime { get; set; }
        public string? Description { get; set; }
        public string? Classification { get; set; }
        [ForeignKey("ClientItem")]
        public int Client { get; set; } 
        public ClientItem? ClientItem { get; set; }
        public bool IsComplete { get; set; }
        public string? Resolution { get; set; }
    }
}
