using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood2.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1024)]
        public string Body { get; set; }

        [Range(1,10)]
        [Required]
        public int Rating { get; set; }

        [DisplayName("Reviewer")]
        public string ReviewerName { get; set; }
        public int RestaurantId { get; set; }
    }
}