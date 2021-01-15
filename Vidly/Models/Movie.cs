﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int NumberInStock{ get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        public int GenreId { get; set; }
    }
}