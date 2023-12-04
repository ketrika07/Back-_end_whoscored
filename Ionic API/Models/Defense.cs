using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ionic_API.Models
{
    public class Defense
    {
        [Key]
        public int idDefense { get; set; }

        [ForeignKey("Equipe")]
        public int idEquipe { get; set; }


        public int sousType { get; set; }
        public double tirsPM { get; set; }
        public double taclesPM { get; set; }
        public double interceptionsPM { get; set; }
        public double fautesPM { get; set; }
        public double horsJeuxPM { get; set; }
        public double note { get; set; }

        //navigation properties
        public virtual Equipe Equipe { get; set; }
    }
}
