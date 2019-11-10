using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EmptyFlow.Models;

namespace EmptyFlow.Pages
{
    public class CreateModel : PageModel
    {
        private readonly EmptyFlow.Models.EmptyFlowContext _context;

        public CreateModel(EmptyFlow.Models.EmptyFlowContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BlogPost.Add(BlogPost);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}