using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperShop.Web.Models
{
    public class AddItemViewModel
    {
        [Display(Name = "Product")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a product.")]
        public int ProductId { get; set; }


        [Range(0.0001, double.MaxValue, ErrorMessage = "You must select a quantity.")]
        public double Quantity { get; set; }

        public IEnumerable<SelectListItem> Products { get; set; }
    }
}
