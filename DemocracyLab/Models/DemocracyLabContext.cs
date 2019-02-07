using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DemocracyLab.Models
{
    public class DemocracyLabContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Voter> Voters { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}