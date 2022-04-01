using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ExemploBrigde.Domain;
using ExemploBrigde.Implementor;

namespace ExemploBrigde.ConcreteImplementor
{
    public class GeraJson : IGeraArquivo
    {
        private string nomeArquivo = "SalarioFuncionario.json";

        public void GravaArquivo(Funcionario funcionario)
        {
            var funcionarioSerializado = JsonSerializer.Serialize(funcionario);
            File.WriteAllText(nomeArquivo, funcionarioSerializado);
            Console.WriteLine($"Salario do funcionaro: {funcionario.Nome} // Incentivo de R$ {funcionario.Incentivo}. " + $" \n **Arquivo gerado com sucesso em : {nomeArquivo}** \n");
        }
    }
}
