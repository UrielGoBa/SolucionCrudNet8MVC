﻿using System.ComponentModel.DataAnnotations;

namespace CrudNet8MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        
        [Required (ErrorMessage = "El Teléfono es obligatorio")]
        public int? Telefono { get; set; }
        
        [Required (ErrorMessage = "El Celular es Obligatorio")]
        public int? Celular { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
