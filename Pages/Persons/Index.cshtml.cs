using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using forSolarLab.Data;
using forSolarLab.Models;


namespace forSolarLab.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly forSolarLab.Data.forSolarLabContext _context;

        public IndexModel(forSolarLab.Data.forSolarLabContext context)
        {
            _context = context;
        }
        public IList<Person> Person { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Month { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }
       

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = (from m in _context.Person
                                            orderby m.FullName
                                            select m.FullName);

            var movies = from m in _context.Person
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.FullName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.FullName == MovieGenre);
            }
            Month = new SelectList(await genreQuery.Distinct().ToListAsync());
            Person = await movies.ToListAsync();

            //Movie = await movies.ToListAsync();
            //Person = await _context.Person.ToListAsync();
        }
    }
}
