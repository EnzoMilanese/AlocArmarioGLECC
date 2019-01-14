using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Model.Metadados
{
    [MetadataType(typeof(BlocoMetadado))]
    public partial class Bloco { }

    class BlocoMetadado
    {
        [Required(ErrorMessage = "Campo \"Seção\" vazio.")]
        public int IdSecao { get; set; }
    }
}