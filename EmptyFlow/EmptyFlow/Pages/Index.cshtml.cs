using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmptyFlow.Models;

namespace EmptyFlow.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EmptyFlow.Models.EmptyFlowContext _context;

        public IndexModel(EmptyFlow.Models.EmptyFlowContext context)
        {
            _context = context;
        }

        public IList<BlogPost> BlogPost { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {
            var posts = from p in _context.BlogPost
                        select p;
            if (!string.IsNullOrEmpty(SearchString)) {
                posts = posts.Where(s => s.Title.Contains(SearchString));
            }
            BlogPost = await posts.ToListAsync();
        }
    }
}
