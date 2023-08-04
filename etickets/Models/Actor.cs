using etickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Models
{
    public class Actor:IEntityBase
        // we will inherit Id from IEntity base as we have made a common interface for all the common fields
    {
        [Key]
        //id is the unique identifier
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")] 
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]

        public string Bio { get; set; }
        //relationships
        public List<Actor_Movie> Actor_Movies { get; set; }


    }
}
