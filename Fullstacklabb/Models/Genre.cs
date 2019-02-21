using System;
using System.ComponentModel.DataAnnotations;

namespace Fullstacklabb.Models
{
    public class  Genre
    {
        public Genre()
        {
            Id = (new Guid()).ToString();
        }
        public string  Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
