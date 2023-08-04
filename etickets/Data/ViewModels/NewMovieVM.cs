using etickets.Data;
using etickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Display(Name="Movie Name")]
        [Required(ErrorMessage ="Movie Name is required")]
        public string Name { get; set; }
        [Display(Name="Movie Description")]
        [Required(ErrorMessage ="Description is required")]
        public string Description { get; set; }
        [Display(Name ="Price in $")]
        [Required(ErrorMessage ="Price is required")]
        public double Price { get; set; }
        [Display(Name ="Movie poster URL")]
        [Required(ErrorMessage ="Movie poster is required ")]
        public string ImageURL { get; set; }
        [Display(Name="Start Date")]
        [Required(ErrorMessage ="Start Date is required")]
        public DateTime StartDate { get; set; }
        [Display(Name ="End Date")]
        [Required(ErrorMessage ="End Date is required")]
        public DateTime EndDate { get; set; }
        [Display(Name ="Select a category")]
        [Required(ErrorMessage ="Movie Category is required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name="Select actor(s)")]
        [Required(ErrorMessage ="Movie actor(s) is required")]
        public List<int> ActorIds { get; set; }
        
        //Cinema
        [Display(Name ="Select a cinema")]
        [Required(ErrorMessage ="Movie Cinema is required")]
        public int CinemaId { get; set; }
       

        //Producer
        [Display(Name ="Select a producer")]
        [Required(ErrorMessage ="Movie Producer is required")]
        public int ProducerId { get; set; }
       







    }
}
