using System.ComponentModel.DataAnnotations;

namespace TelaInicialCrud.Areas.Identity.Data
{
    public class Projeto
    {
        [Key]
        public int IdProjeto { get; set; }
        public string NomeProjeto { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int QuantPessoas { get; set; }

    }
}
