using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.DomainPorject
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        [NotMapped]
        public string Email { get; set; }

        [NotMapped]
        public DateTime DataCadastro { get; set; }

        [NotMapped]
        public bool Ativo { get; set; }

        public List<Disciplina> Disciplinas { get; set; }

    }
}
