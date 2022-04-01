using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploBrigde.Abstration;
using ExemploBrigde.Domain;
using ExemploBrigde.Implementor;

namespace ExemploBrigde.RefinedAbstration
{
    public class CalculaSalario : AbastrationGeraArquivo
    {
        public CalculaSalario(IGeraArquivo geraArquivo) : base(geraArquivo)
        { }
        public void ProcessaSalarioFuncionario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;
            Console.WriteLine($"Salario total do funcionario ID:{funcionario.Id}" + $" é de R$ {funcionario.SalarioTotal}.");
            geraArquivo.GravaArquivo(funcionario);
        }
    }
}
