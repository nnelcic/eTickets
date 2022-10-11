using eTickets.Data;
using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Movie Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price in $")] 
        public double Price { get; set; }

        [Required(ErrorMessage = "Movie poster URL is required")]
        [Display(Name = "Movie poster URL")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Movie Category is required")]
        [Display(Name = "Select Category")]
        public MovieCategory MovieCategory { get; set; }

        // Relations 
        [Required(ErrorMessage = "Movie Actor(s) is required")]
        [Display(Name = "Select Actor(s)")]
        public List<int> ActorId { get; set; }

        [Required(ErrorMessage = "Movie cinema is required")]
        [Display(Name = "Select a cinema")]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Movie producer is required")]
        [Display(Name = "Select a producer")]
        public int ProducerId { get; set; }
    }
}
