using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace AnamSerkan.Models
{
    public class MessageDbContext : DbContext
    {
        public MessageDbContext()
            : base()
        {
        }

        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
