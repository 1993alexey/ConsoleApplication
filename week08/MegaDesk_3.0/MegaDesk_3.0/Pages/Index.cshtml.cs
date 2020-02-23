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
        }

        public IList<QuoteModel> QuoteModel { get;set; }

        public async Task OnGetAsync()
        {
            QuoteModel = await _context.QuoteModel.ToListAsync();
        }
    }
}
