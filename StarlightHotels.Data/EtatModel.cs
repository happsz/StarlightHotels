﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarlightHotels.Models
{
    [Table("Etat")]
    public class EtatModel
    {
        [Key]
        [Column("ETAT_Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("ETAT_Libelle")]
        [Display(Name = "Libelle")]
        public string Libelle { get; set; }

        public ICollection<ReservationModel> Reservations { get; set; }
    }
}