using email_scheduler.Server.Data;
using email_scheduler.Server.Entities;
using email_scheduler.Server.Interfaces;

namespace email_scheduler.Server.Repositories
{
    //write test for this
    public class EmailRepository : IRepository<Email>, IDisposable
    {
        private EmailSchedulerDbContext context;
        public EmailRepository(EmailSchedulerDbContext context) { 
            this.context = context;
        }
    }
}
