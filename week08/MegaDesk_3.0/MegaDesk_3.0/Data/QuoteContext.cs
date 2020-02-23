using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk_3._0.Models;

    public class QuoteContext : DbContext
    {
        public QuoteContext (DbContextOptions<QuoteContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk_3._0.Models.QuoteModel> QuoteModel { get; set; }
    }
