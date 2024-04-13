namespace email_scheduler.Server.Entities
{
    public class EmailSends : BaseEntity
    {
        public Guid emailId { get; set; }

        public Boolean sent { get; set; }

        // TODO add error lists
    }
}
