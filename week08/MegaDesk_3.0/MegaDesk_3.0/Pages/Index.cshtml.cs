using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_3._0.Models;

namespace MegaDesk_3._0.Pages
{
    public class IndexModel : PageModel
    {
        private readonly QuoteContext _context;

        public IndexModel(QuoteContext context)
        {
            _context = context;
            Models.QuoteModel.LoadRushPrices();
        }

        public IList<QuoteModel> QuoteModel { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortBy { get; set; }

        public async Task OnGetAsync()
        {
            var quotes = from m in _context.QuoteModel select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(s => s.Name.Contains(SearchString));
            }

            if (SortBy == "name")
                quotes = quotes.OrderBy(s => s.Name);
            else
                quotes = quotes.OrderByDescending(s => s.Date);

            QuoteModel = await quotes.ToListAsync();
        }
    }
}
