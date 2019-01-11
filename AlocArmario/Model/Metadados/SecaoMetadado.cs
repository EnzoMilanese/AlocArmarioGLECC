using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Model.Metadados
{
    [MetadataType(typeof(SecaoMetadado))]
    public partial class Secao { }

    class SecaoMetadado
    {
        [Required(ErrorMessage = "Campo \"Nome\" vazio.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo \"Descrição\" vazio.")]
        public string Descricao { get; set; }
    }
}