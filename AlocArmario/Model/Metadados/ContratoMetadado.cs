using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Model.Metadados
{
    [MetadataType(typeof(ContratoMetadado))]
    public partial class Contrato { }

    class ContratoMetadado
    {
        [Required(ErrorMessage = "Campo \"Locatário\" vazio.")]
        public Locatario Locatario { get; set; }

        [Required(ErrorMessage = "Campo \"Armário\" vazio.")]
        public Armario Armario { get; set; }
    }
}
