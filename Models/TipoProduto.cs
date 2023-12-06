using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SistemaProduto.Models
{
    public class TipoProduto
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo Produto")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Descricao da produto")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;

    }
}
