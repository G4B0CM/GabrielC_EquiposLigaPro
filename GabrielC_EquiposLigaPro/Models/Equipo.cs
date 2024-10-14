﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GabrielC_EquiposLigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        public bool Extranjeros { get; set; }
        [ForeignKey("Estadio")]
        public int IDEstadio { get; set; }
    }
}
