﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarmaniaHotels.API.Models
{
    [Table("Hotel")]
    public class Hotel
    {
        [Key]
        [Display(Name = "HOTEL_Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "HOTEL_Nom")]
        [StringLength(50)]
        public string Nom { get; set; }

        [Required]
        [Display(Name = "HOTEL_NbEtoiles")]
        public int NbEtoiles { get; set; }

        [Required]
        [Display(Name = "HOTEL_NombreChambres")]
        public int NbChambres { get; set; }

        [Required]
        [Display(Name = "HOTEL_Description")]
        [DataType(DataType.MultilineText)]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "HOTEL_Adresse")]
        [DataType(DataType.MultilineText)]
        [StringLength(255)]
        public string Adresse { get; set; }

        [Required]
        [Display(Name = "HOTEL_CodePostal")]
        [DataType(DataType.PostalCode)]
        [StringLength(20)]
        public string CodePostal { get; set; }

        [Required]
        [Display(Name = "HOTEL_Ville")]
        [StringLength(60)]
        public string Ville { get; set; }

        // Relation avec l'entité Pays
        public int PaysId { get; set; }
        public Pays Pays { get; set; }

        [Required]
        [Display(Name = "HOTEL_Telephone")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(100)]
        public string Telephone { get; set; }

        [Required]
        [Display(Name = "HOTEL_EnPromotion")]
        public bool EnPromotion { get; set; }

        [Required]
        [Display(Name = "HOTEL_TopDestination")]
        public bool TopDestination { get; set; }

        [Required]
        [Display(Name = "HOTEL_Actif")]
        public bool Actif { get; set; }

        [Display(Name = "HOTEL_Coefficient")]
        public bool Coefficient { get; set; }

        public List<Chambre> Chambres { get; set; }

        public List<Image> Images { get; set; }

        public ICollection<HotelFormule> HotelFormules { get; set; }
        public ICollection<HotelService> HotelServices { get; set; }
        public ICollection<HotelTheme> HotelThemes { get; set; }
        public ICollection<HotelCategorie> HotelCategories { get; set; }
    }
}