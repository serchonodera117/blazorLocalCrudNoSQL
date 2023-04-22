using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto_programación_web.Shared.Models
{
    public class Editorial
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "No pudes dejar vacío el nombre de la editorial")]
        public string NombreManga { get; set; }
        //public ICollection<Manga> Mangas { get; set; }
    }
}
