using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MisPeliculas
{
    public class Pelicula
    {
        [Key]
        public int PeliculaId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Director { get; set; }
        public int Year { get; set; }
        [MaxLength(100)]
        public string Genero { get; set; }
        public int Valor { get; set; }
        public bool Vista { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
