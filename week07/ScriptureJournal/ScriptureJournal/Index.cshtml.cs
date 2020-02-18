using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;

namespace ScriptureJournal
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournalDbContext _context;

        public IndexModel(ScriptureJournalDbContext context)
        {
            _context = context;
        }

        public IList<JournalModel> JournalModel { get;set; }

        public async Task OnGetAsync()
        {
            JournalModel = await _context.JournalModel.ToListAsync();
        }
    }
}
