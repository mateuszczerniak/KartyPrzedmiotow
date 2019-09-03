using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KartyPrzedmiotow2.Models
{
    public class UserEditViewModel
    {
        public UserEditViewModel()
        {
            WybraneWydzialy = new List<int>();
            WybraneTytuly = new List<int>();
            WybraneRole = new List<string>();
        }

        [Required]
        public string Id { get; set; }
        [Required]
        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }
        public List<SelectListItem> Wydzialy { get; set; }
        public List<SelectListItem> Tytuly { get; set; }
        public List<SelectListItem> Role { get; set; }
        [Display(Name = "Wydziały")]
        public List<int> WybraneWydzialy { get; set; }
        [Display(Name = "Tytuły")]
        public List<int> WybraneTytuly { get; set; }
        [Display(Name = "Role")]
        public List<string> WybraneRole { get; set; }
    }
}