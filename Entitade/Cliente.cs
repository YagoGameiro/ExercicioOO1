using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitade
{
    public class Cliente : Pessoa
    {
        #region Propriedades
        public GrauSatisfacao GrauSatisfacao { get; set; }
        #endregion Propriedades

        #region Métodos

        public override string ToString()
        {
            return base.ToString() + 
                "\nId Cliente: " + this.GrauSatisfacao.Id +
                "\nGrau de Satisfação: " + this.GrauSatisfacao.Descricao;
        } 
        #endregion Métodos
    }
}
