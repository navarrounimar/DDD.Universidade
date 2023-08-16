using DDD.Unimar.Domain.Entities;

namespace DDD.Persistence.Memory
{
    public class ListContext
    {
        public List<Aluno> Alunos { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public ListContext()
        {
            Alunos = new List<Aluno>();
            Disciplinas = new List<Disciplina>();
        }
    }
}