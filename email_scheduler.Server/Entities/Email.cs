using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace email_scheduler.Server.Entities
{
    public class Email : BaseEntity
    {
        [MaxLength(255)]
        public String? Subject { get; set; }

        public String? Body { get; set; }        
        [MaxLength(255)]
        [Required]
        public required String ToEmail { get; set; }

        public DateTime? SendTime { get; set; }

        [Required]
        public Boolean RecurringEmail { get; set; } = false;
        //TODO: want to implement proper deletes later
        [Required]
        public Boolean Archived { get; set; } = false;
        public DateTime? EmailExpiry { get; set; }
        [Required]
        [ForeignKey("User")]
        public Guid UserId {  get; set; }
        public virtual ApplicationUser UserIdentity { get; set; }
    }
}
