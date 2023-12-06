﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("Id")]
        [Display(Name = "Código do País")]
        public int Id { get; set; }

        [Column("PaisNome")]
        [Display(Name = "Nome do país")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
