﻿using System.ComponentModel.DataAnnotations;

namespace Shopping_Site.Models
{
    public class Unit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

    }
}
