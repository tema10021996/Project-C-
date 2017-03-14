using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities
{
    public class Game
    {
        [HiddenInput(DisplayValue = false)]
        public int GameId { get; set; }

        [Display(Name = "Название")]
        
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        
        public string Description { get; set; }

        [Display(Name = "Категория")]
        
        public string Category { get; set; }

        [Display(Name = "Цена (руб)")]
        
        public decimal Price { get; set; }
    }
}