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
    
    public partial class Bloco
    {
        public Bloco()
        {
            this.Armario = new HashSet<Armario>();
        }
    
        public int IdBloco { get; set; }
        public string Nome { get; set; }
        public int IdSecao { get; set; }
    
        public virtual ICollection<Armario> Armario { get; set; }
        public virtual Secao Secao { get; set; }
    }
}
