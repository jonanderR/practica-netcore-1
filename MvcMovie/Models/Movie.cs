﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [Display(Name ="Fecha de lanzamiento")]
        [DataType(DataType.Date)]
        public DateTime RealeseDate { get; set; }
        public string? Genre { get; set; }
        [Column(TypeName ="decimal(18, 2)")]
        public decimal Price { get; set; }  
        public string? Rating { get; set; }
    }
}
