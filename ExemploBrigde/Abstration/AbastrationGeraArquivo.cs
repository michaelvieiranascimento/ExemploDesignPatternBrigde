using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploBrigde.Domain;
using ExemploBrigde.Implementor;

namespace ExemploBrigde.Abstration
{
    public abstract class AbastrationGeraArquivo
    {
        protected IGeraArquivo geraArquivo;

        protected AbastrationGeraArquivo(IGeraArquivo geraArquivo)
        {
            this.geraArquivo = geraArquivo;
        }
        public virtual void GravaArquivo(Funcionario funcionario)
        {
            geraArquivo.GravaArquivo(funcionario);
        }
     }
}
