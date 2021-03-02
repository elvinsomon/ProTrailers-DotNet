using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProTrailers.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }
        [Required]
        [StringLength(50)]
        public string Genero { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Sinopsis { get; set; }
        [Required]
        [StringLength(100)]
        public string Director { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [Required]
        [DataType(DataType.Url)]
        public string Video { get; set; }
    }
}
