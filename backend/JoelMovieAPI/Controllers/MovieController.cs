using Microsoft.AspNetCore.Mvc;
using JoelMovieAPI.Models;

namespace JoelMovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MovieController : Controller
    {
        private JoelHiltonMovieCollectionContext context;

        public MovieController(JoelHiltonMovieCollectionContext temp) { 
            context = temp;
        }

        public IEnumerable<Movie> Get()
        {
            var data = context.Movies
                .Where(x => x.Edited == "Yes")
                .OrderBy(x => x.Title)
                .ToArray();

            return data;
        }

    }
}
