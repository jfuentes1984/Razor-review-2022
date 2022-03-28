#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_review_2022.Model;

namespace Razor_review_2022.Pages.Student
{
    public class IndexModel : PageModel
    {
        private readonly DBContext _context;

        public IndexModel(DBContext context)
        {
            _context = context;
        }

        public IList<Razor_review_2022.Model.Student> Student { get; set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
