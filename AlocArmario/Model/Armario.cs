//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlocArmario.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Armario
    {
        public Armario()
        {
            this.Contrato = new HashSet<Contrato>();
        }

        public Armario(string num, Bloco bloco)
        {
            this.Contrato = new HashSet<Contrato>();
            this.Numero = num;
            this.Bloco = bloco;
            this.IdBloco = bloco.IdBloco;
        }

        public int IdArmario { get; set; }
        public int IdBloco { get; set; }
        public string Numero { get; set; }
    
        public virtual ICollection<Contrato> Contrato { get; set; }
        public virtual Bloco Bloco { get; set; }
    }
}
