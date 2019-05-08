using System.Collections.Generic;

namespace MovieApp.Models
{
    public class MovieCategoryModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}