using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClubCore.Data.Entities
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(11)]
        [RegularExpression(@"[\d]{6,10}", ErrorMessage = "Ingrese DNI solo con números (sin puntos ni espacios)")]
        public string Dni { get; set; }

    }
}
