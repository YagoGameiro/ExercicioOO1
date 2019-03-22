using Entitade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario()
            {
                Id = 1,
                Nome = "José",
                Salario = 1000,
                Sexo = "Masculino",
                Endereco = "Rua 1",
                Telefone = "(16) 3882-4556"
            };

            Console.WriteLine(funcionario);
            Console.ReadKey();
            
        }
    }
}
