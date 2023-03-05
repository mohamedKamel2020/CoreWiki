﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreWiki.Models;

namespace CoreWiki.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CoreWiki.Models.ApplicationDbContext _context;

        public IndexModel(CoreWiki.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Articles != null)
            {
                Article = await _context.Articles.ToListAsync();
            }
        }
    }
}
