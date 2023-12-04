using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ionic_API.Models
{
    public class Attaque
    {
        [Key]
        public int idAttaque { get; set; }

        [ForeignKey("Equipe")]
        public int idEquipe { get; set; }

        public int sousType { get; set; }
        public double tirsPM { get; set; }
        public double tirsCApm { get; set; }
        public double dribblesPM { get; set; }
        public double fautesSubiesPM { get; set; }
        public double note { get; set; }

        //navigation properties
        public virtual Equipe Equipe { get; set; }
    }
}
