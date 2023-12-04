using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ionic_API.Models
{
    public class Equipe
    {
        [Key]
        public int idEquipe { get; set; }
        public string nomEquipe { get; set; }

        [ForeignKey("Competition")]
        public int idCompetition { get; set; }

        //navigation property
        public virtual Competition Competition { get; set; }
    }
}
