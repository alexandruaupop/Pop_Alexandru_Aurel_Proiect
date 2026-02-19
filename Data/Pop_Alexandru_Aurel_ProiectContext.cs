using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Alexandru_Aurel_Proiect.Models;

namespace Pop_Alexandru_Aurel_Proiect.Data
{
    public class Pop_Alexandru_Aurel_ProiectContext : DbContext
    {
        public Pop_Alexandru_Aurel_ProiectContext (DbContextOptions<Pop_Alexandru_Aurel_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Pop_Alexandru_Aurel_Proiect.Models.Member> Member { get; set; } = default!;
        public DbSet<Pop_Alexandru_Aurel_Proiect.Models.SubscriptionType> SubscriptionType { get; set; } = default!;
        public DbSet<Pop_Alexandru_Aurel_Proiect.Models.Trainer> Trainer { get; set; } = default!;
        public DbSet<Pop_Alexandru_Aurel_Proiect.Models.Subscription> Subscription { get; set; } = default!;
    }
}
