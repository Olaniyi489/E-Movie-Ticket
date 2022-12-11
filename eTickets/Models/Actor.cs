using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Profile Picture is required")]
        [Display(Name ="Profile Picture")]
        public string ProfilePictureUrl { get; set; }

        [Required(ErrorMessage ="Full name is required")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Biography is required")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
