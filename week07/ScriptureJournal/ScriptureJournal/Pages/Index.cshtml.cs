using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly JournalDbContext _context;

        public IndexModel(JournalDbContext context)
        {
            _context = context;
        }

        public IList<JournalModel> JournalModel { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchType { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortBy { get; set; }

        public async Task OnGetAsync()
        {
            var journals = from m in _context.JournalModel
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                if (SearchType.Equals("book"))
                    journals = journals.Where(s => s.Book.Contains(SearchString));
                else
                    journals = journals.Where(s => s.Notes.Contains(SearchString));
            }

            if (SortBy == "book")
                journals = journals.OrderBy(s => s.Book);
            else
                journals = journals.OrderByDescending(s => s.CreatedAt);

            JournalModel = await journals.ToListAsync();
        }
    }
}
