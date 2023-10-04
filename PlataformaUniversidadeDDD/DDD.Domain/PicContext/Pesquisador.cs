using DDD.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.PicContext
{
    public  class Pesquisador : User
    {
        public string Titulacao { get; set; }

        //Um Pesquisador só pode atuar em Um Projeto
        //Nullable para representar que um pesquisador pode existir sem nenhum projeto
        public Projeto? Projeto { get; set; } 
    }
}
