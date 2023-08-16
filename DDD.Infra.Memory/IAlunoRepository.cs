using DDD.Unimar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.Memory
{
    public interface IAlunoRepository
    {
        public List<Aluno> GetAlunos();
    }
}
