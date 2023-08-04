using etickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        //id is the unique identifier
        public int Id { get; set; }
        [Display(Name="Cinema Logo")]
        [Required(ErrorMessage ="Cinema Logo is required")]
        public string Logo { get; set; }
        [Display(Name="Cinema Name")]
        [Required(ErrorMessage ="Cinema Name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Cinema Name must be between 3 and 50 characters")]
        public string Name { get; set; }
        [Display(Name ="Description")]
        [Required(ErrorMessage ="Cinema Description is required")]
        public string Description { get; set; }
        //Relationships
        //cinema has multiple movies 
       //one to many relationship
        public List<Movie> Movies { get; set; }


    }
}
