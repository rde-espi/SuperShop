using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace SuperShop.Web.Data.Entities
{
    public class City : IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="City")]
        [MaxLength(50, ErrorMessage = "The field {0} can contain {1} characters.")]
        public string Name { get; set; }
    }
}
