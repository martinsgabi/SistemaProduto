﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("Id")]
        [Display(Name = "Código do Fornecedor")]
        public int Id { get; set; }

        [Column("FornecedorNome")]
        [Display(Name = "Nome do fornecedor")]
        public string FornecedorNome { get; set; } = string.Empty;

        [Column("FornecedorEmail")]
        [Display(Name = "Email do fornecedor")]
        public string FornecedorEmail { get; set; } = string.Empty;

        [Column("FornecedorCnpj")]
        [Display(Name = "CNPJ do fornecedor")]
        public string FornecedorCnpj { get; set; } = string.Empty;
    }
}
