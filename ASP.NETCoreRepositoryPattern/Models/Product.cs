using ASP.NETCoreRepositoryPattern.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreRepositoryPattern.Models
{
    public class Product : IEntity
    {
        public int id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public float Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
