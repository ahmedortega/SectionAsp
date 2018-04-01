using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Cusomer Name is Required!")]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Cusomer Age is Required!")]
        [Display(Name = "Customer Age")]
        public int Age { get; set; }
        [Display(Name = "Are U Male ?")]
        public bool IsMale { get; set; }
        public MemberShipType MemberShipType { get; set; }
        [Required(ErrorMessage = "The Cusomer MemberShip is Required!")]
        [Display(Name = "Customer MemberShip")]
        public int? MemberShipTypeID { get; set; }


    }
}