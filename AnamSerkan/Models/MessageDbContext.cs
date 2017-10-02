using Microsoft.EntityFrameworkCore;

namespace AnamSerkan.Models
{
    public class MessageDbContext : DbContext
    {
        public MessageDbContext(DbContextOptions<MessageDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Message> Messages { get; set; }
    }
}
