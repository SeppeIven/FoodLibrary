using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Dish
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public int PreparationTimeMinutes { get; set; }

        [Display(Name = "Meat")]
        public string Meat { get; set; }

        public string MealType { get; set; }

    }
 

}

