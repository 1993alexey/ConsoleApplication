using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;

    public class JournalDbContext : DbContext
    {
        public JournalDbContext (DbContextOptions<JournalDbContext> options)
            : base(options)
        {
        }

        public DbSet<ScriptureJournal.Models.JournalModel> JournalModel { get; set; }
    }
