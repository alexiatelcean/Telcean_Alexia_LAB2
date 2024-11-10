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
    public class DetailsModel : PageModel
    {
        private readonly Telcean_Lorena_Alexia_LAB2.Data.Telcean_Lorena_Alexia_LAB2Context _context;

        public DetailsModel(Telcean_Lorena_Alexia_LAB2.Data.Telcean_Lorena_Alexia_LAB2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
