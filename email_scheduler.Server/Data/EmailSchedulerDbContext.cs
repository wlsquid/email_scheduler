using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace email_scheduler.Server.Data
{
    public class EmailSchedulerDbContext : IdentityDbContext<IdentityUser>
    {
        public EmailSchedulerDbContext(DbContextOptions<EmailSchedulerDbContext> options) :
       base(options)
        { }
    }
}
