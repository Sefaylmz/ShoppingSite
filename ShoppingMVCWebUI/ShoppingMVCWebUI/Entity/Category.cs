using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingMVCWebUI.Entity
{
    public class Category
    {
        [Display(Name = "Категория")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Категория")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        public List<Product> products { get; set; }
    }
}