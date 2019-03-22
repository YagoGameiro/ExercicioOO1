using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitade
{
    public abstract class Pessoa
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Sexo { get; set; }

        #endregion Propriedades

        #region Métodos
        public override string ToString()
        {
            return  "Id: " + this.Id +
                    "\nNome: " + this.Nome +
                    "\nTelefone: " + this.Telefone +
                    "\nEndereço: " + this.Endereco +
                    "\nSexo: " + this.Sexo;

        }
        #endregion Métodos
    }
}
