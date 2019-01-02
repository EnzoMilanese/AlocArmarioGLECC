using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Model
{
    [MetadataType(typeof(LocatarioMetadado))]
    public partial class Locatario { }

    class LocatarioMetadado
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O prontuário é obrigatório.")]
        [StringLength(7, MinimumLength = 5, ErrorMessage = "O prontuário deve ter entre 5 e 7 dígitos")]
        public string Prontuario { get; set; }
    }
}
