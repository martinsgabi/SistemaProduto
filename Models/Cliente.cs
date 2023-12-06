using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código do Cliente")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteDataNascimento")]
        [Display(Name = "Data de nascimento do cliente")]
        public DateTime ClienteDataNascimento { get; set; }

        [Column("ClienteCpf")]
        [Display(Name = "CPF do cliente")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteEndereco")]
        [Display(Name = "Endereço do cliente")]
        public string ClienteEndereco { get; set; } = string.Empty;

        [Column("NumeroCasaCliente")]
        [Display(Name = "Numero da casa do cliente")]
        public string NumeroCasaCliente { get; set; } = string.Empty;

        [Column("BairroCliente")]
        [Display(Name = "Nome do bairro do cliente")]
        public string BairroCliente { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

        [Column("TelefoneCliente")]
        [Display(Name = "Telefone do cliente")]

        public string TelefoneCliente { get; set; } = string.Empty;
    }
}
