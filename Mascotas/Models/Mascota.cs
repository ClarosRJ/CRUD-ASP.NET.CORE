using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Mascotas.Models
{
    public class Mascota
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(50)")]
        [DisplayName("Nombre")]
        public String Name { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [DisplayName("Años")]
        public int Age { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Color")]
        public String Color { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Genero")]
        public String Gender { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Propietario")] 
        public String OwnerName { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Dirección")]
        public String Address { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Nombre Imagen")]
        public string ImageName { get; set; } = "Default";

        [NotMapped]
        [DisplayName("Subir Imagen")]
        public IFormFile ImageFile { get; set; }

    }
}
