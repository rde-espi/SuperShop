using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SuperShop.Web.Models
{
    public class ChangeUserViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirtsName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
