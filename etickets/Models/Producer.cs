using etickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        //id is the unique identifier
        public int  Id{ get; set; }
        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")]


        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage ="Biography is required")]
        public string Bio { get; set; }

        //Relationships
        //Producer can have multiple movies
        public List<Movie> Movies { get; set; }

    }
}
