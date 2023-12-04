using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ionic_API.Models
{
    public class General
    {
        [Key]
        public int idGeneral { get; set; }

        [ForeignKey("Equipe")]
        public int idEquipe { get; set; }


        public int sousType { get; set; }
        public double buts { get; set; }
        public double tirePM { get; set; }
        public double jaune { get; set; }
        public double rouge { get; set; }
        public double possession { get; set; }
        public double passesReussies { get; set; }
        public double aeriensGagnes { get; set; }
        public double note {  get; set; }


        //navigation properties
        public virtual Equipe Equipe { get; set; }

    }
}
