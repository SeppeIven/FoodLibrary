using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class DishIngredientRelation
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public Dish dish { get; set; }

        [Required]
        public Ingredient ingredient { get; set; }

        public int AmountPerPerson { get; set; }

        public string UnitType { get; set; }

    }


}

