using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KartyPrzedmiotow2.Models
{
    public class GrupyMetodList
    {
        public List<SelectListItem> GrupyMetod { get; set; }
        public int GrupyMetodDydaktycznychId { get; set; }
        public string Nazwa { get; set; }
    }
}