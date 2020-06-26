﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarlightHotels.API.Models
{
    [Table("Service")]
    public class ServiceModel
    {
        [Key]
        [Display(Name = "SERV_Id")]
        public int Id { get; set; }

        [Display(Name = "SERV_Description")]
        [DataType(DataType.MultilineText)]
        [StringLength(255)]
        public string Description { get; set; }

        [Display(Name = "SERV_Payant")]
        public bool Payant { get; set; }

        public ICollection<HotelServiceModel> HotelServices { get; set; }
    }
}