using System;
using System.ComponentModel.DataAnnotations;

namespace Fullstacklabb.Models
{
    public class Gig
    {
        public Gig()
        {
            Id = (new Guid()).ToString();
        }

        public string Id { get; set; }

        [Required]
        public string ArtistId { get; set; }
        [Required]
        public GigUser Artist { get; set; }


        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public string GenreID { get; set; }
        [Required]
        public Genre Genre { get; set; }

    }
}
