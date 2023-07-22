using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace SuperShop.Web.Models
{
    public class DeliveryViewModel
    {
        public int id { get; set; }

        [Display(Name = "Delivery Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DeliveryDate { get; set; }
    }
}
