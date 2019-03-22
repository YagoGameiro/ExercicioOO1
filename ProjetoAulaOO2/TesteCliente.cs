using Entitade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaOO2
{
    public class TesteCliente
    {
        public static void Main(string[] args)
        {

            Cliente cliente = new Cliente()
            {
                Id = 1,
                Endereco = "Rua 10",
                Nome = "João",
                Sexo = "Feminino",
                Telefone = "(16) 8080-7070",
                GrauSatisfacao = new GrauSatisfacao { Id = 1, Descricao = "Bom"}
            };

            Console.WriteLine(cliente);

            Console.ReadKey();
        }
    }
}
