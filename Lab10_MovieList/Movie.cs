using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_MovieList
{
    class Movie
    {

        public string title { get; set; }
        public string category { get; set; }

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
    }
}
