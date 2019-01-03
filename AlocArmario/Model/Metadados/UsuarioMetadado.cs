using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Model.Metadados
{
    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuario { }

    class UsuarioMetadado
    {
        [Required(ErrorMessage = "Campo 'prontuário' vazio.")]
        public string Prontuario { get; set; }

        [Required(ErrorMessage = "Campo 'senha' vazio.")]
        public string Senha { get; set; }
    }
}
