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
    
    public partial class Locatario
    {
        public Locatario()
        {
            this.Contrato = new HashSet<Contrato>();
        }
    
        public int IdLocatario { get; set; }
        public string Nome { get; set; }
        public string Prontuario { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Nullable<bool> TemContrato { get; set; }
        public int ContratoAtivo { get; set; }
    
        public virtual ICollection<Contrato> Contrato { get; set; }
    }
}
