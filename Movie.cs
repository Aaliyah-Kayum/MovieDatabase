using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    internal class Movie
    {
        public string Title { get; set; }

        public Movie(string _title)
        {
            Title = _title;
        }
        public string Category { get; set; }

        public Movie(string _category)
        {
            Category = _category;
        }

        //IEnumerable<string> movieCategory =
        //    from Category in Movie
        //    where Category[0] == _category
        //    select Category[0];

        //foreach (int i in movieCategory)
        //    {
        //    Console.Write(int + " ");
        //    }
    }
}