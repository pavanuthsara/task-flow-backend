using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskFlow.Domain.Common;
using TaskFlow.Domain.Enums;

namespace TaskFlow.Domain.Entities
{
    public class Ticket : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;

        public DateTime? DueDate { get; set; }
        public PriorityLevel Priority { get; set; } = PriorityLevel.Medium;
        public TicketStatus Status { get; set; } = TicketStatus.Todo;

        // 1. Relationship to Project (Many to One)
        // A ticket must belong to a project
        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }

        // 2. Relationship to User (Many to One)
        // A ticket might not be assigned to anyone yet (nullable)
        // Note: will create AppUser entity later
        public string? AssignedToUserId { get; set; }
    }
}
