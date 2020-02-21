using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingMVCWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Название Товара")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Фото Товара")]
        public string Image { get; set; }

        [Display(Name = "Цена")]
        public double Price { get; set; }
        [Display(Name = "Склад")]
        public int Stock { get; set; }

        [Display(Name = "Показать на главной странице")]
        public bool IsHome { get; set; }

        [Display(Name = "Есть в Наличии")]
        public bool IsApproved { get; set; }

        [Display(Name = "Категория")]
        public int categoryId { get; set; }

        public Category category { get; set; }
    }
}