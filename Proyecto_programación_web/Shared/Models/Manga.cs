using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto_programación_web.Shared.Models
{
    public class Manga
    {
      
        public int Id { get; set; }
       // [Required(ErrorMessage = "El campo descripcion no puede ir vacío")]
        //public string NombreMANGA  {get; set;}
        [Required(ErrorMessage ="El campo descripcion no puede ir vacío")]
        public string Descripcion { get; set; }
        public int Publicaciones { get; set; }
        public int EditorialId { get; set; }
        public Editorial Editorial { get; set; }
    }
}
