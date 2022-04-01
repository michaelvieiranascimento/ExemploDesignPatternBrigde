using System;
using ExemploBrigde.ConcreteImplementor;
using ExemploBrigde.Domain;
using ExemploBrigde.RefinedAbstration;

namespace ExemploBrigde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RedefinedAbstration recebe via construtor em tempo de execucao
            //O tipo especifico de formato para gerar o arquivo
            //e usa a classe base AbstrationGeraArquivo para obter uma instancia
            //de IGeraArquivo (Brigde)
            CalculaSalario calculaSalario = new CalculaSalario(new GeraXML());

            // Os dados do funcionario
            Funcionario funcionario = new Funcionario
            {
                Id = 95,
                Nome = "Michael",
                SalarioBase = 3000,
                Incentivo = 2000
            };

            //processa o salario
            calculaSalario.ProcessaSalarioFuncionario(funcionario);

            funcionario.Id = 100;

            funcionario.Nome = "Lucas";
            //altera o valor do incentivo em tempo de execucao
            funcionario.Incentivo = 4000;

            //altera o formato para gerar o arquivo em tempo de execucao
            calculaSalario = new CalculaSalario(new GeraJson());

            calculaSalario.ProcessaSalarioFuncionario(funcionario);

            Console.ReadKey();




        }
    }
}
