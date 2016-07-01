using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FormulaireBo
{
    public class Stagiaire
    {
        
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        [DisplayName("Date de naissance")]
        [DataType(DataType.Date)]
        public DateTime DateDenaissance { get; set; }

        [Required]
        public string Adresse { get; set; }

        [Required]
        public string Ville { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public Sexe LeSexe { get; set; }

        [Required]
        public int LeSexeId { get; set; }
        [Required]
        public Qualification LaQualification { get; set; }

        [Required]
        public int LaQualificationId { get; set; }
        public string Autre { get; set; }

        [Required]
        public decimal Remuneration { get; set; }

        [Required]
        [DisplayName("Année du stage")]
        public int AnneeStage { get; set; }
        public string Commentaire { get; set; }
        public Stagiaire()
        {

        }


    }
}
