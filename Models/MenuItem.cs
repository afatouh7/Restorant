using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Spicyness { get; set; }
        public enum ESpicy {NA=0, NotSPice=1, Spicy=2, Veryspice=3 }
        
        public string Image { get; set; }
        [Display(Name ="Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [Display(Name = "SubCategory")]
        public int SUbCategoryId { get; set; }

        [ForeignKey("SUbCategoryId")]
        public virtual SubCategory subCategory { get; set; }
        [Range(1,int.MaxValue, ErrorMessage ="Price should be greater Than ${1}")]
        public double Price { get; set; }
    }
}
