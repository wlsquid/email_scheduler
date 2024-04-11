using System.ComponentModel.DataAnnotations;

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

        public DateTime? EmailExpiry { get; set; }

        public Guid User {  get; set; }
    }
}
