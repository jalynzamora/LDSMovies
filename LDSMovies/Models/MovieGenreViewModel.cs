﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LDSMovies.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies;
        public SelectList Genres;
        public SelectList ReleaseDate;
        public string MovieGenre { get; set; }
        public string MovieReleaseDate { get; set; }
        public string SearchString { get; set; }
    }
}