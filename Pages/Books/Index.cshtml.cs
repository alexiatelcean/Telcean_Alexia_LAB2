using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Telcean_Lorena_Alexia_LAB2.Data;
using Telcean_Lorena_Alexia_LAB2.Models;

namespace Telcean_Lorena_Alexia_LAB2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Telcean_Lorena_Alexia_LAB2.Data.Telcean_Lorena_Alexia_LAB2Context _context;

        public IndexModel(Telcean_Lorena_Alexia_LAB2.Data.Telcean_Lorena_Alexia_LAB2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
