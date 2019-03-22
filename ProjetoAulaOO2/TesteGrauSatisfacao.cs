using Entitade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaOO2
{
    public class TesteGrauSatisfacao
    {
        public static void Main(string[] args)
        {

            GrauSatisfacao gf = new GrauSatisfacao()
            {
                Id = 1,
                Descricao = "Ruim"
            };

            GrauSatisfacao gf2 = new GrauSatisfacao()
            {
                Id = 2,
                Descricao = "Bom"
            };

            GrauSatisfacao gf3 = new GrauSatisfacao()
            {
                Id = 3,
                Descricao = "Muito Bom"
            };

            //Grau Satisfação
            gf.addGrauSastifacao();
            gf2.addGrauSastifacao();
            gf3.addGrauSastifacao();

            foreach (var item in gf.getAll())
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
