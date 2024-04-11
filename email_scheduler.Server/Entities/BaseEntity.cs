using System.ComponentModel.DataAnnotations;

namespace email_scheduler.Server.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
