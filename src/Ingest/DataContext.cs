﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SC2Balance.Models;

namespace SC2Balance.Ingest
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            Database.SetInitializer<DataContext>(null);
        }

        public DbSet<Ingestion> Ingestions { get; set; }
        public DbSet<LadderMember> LadderMembers { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<UniqueGmMatch> UniqueGmMatches { get; set; }
        public DbSet<ProcessingRun> ProcessingRuns { get; set; }
    }
}
