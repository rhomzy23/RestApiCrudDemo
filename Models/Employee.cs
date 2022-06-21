﻿using System.ComponentModel.DataAnnotations;

namespace RestApiCrudDemo.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The Name is too long.")]
        public string Name { get; set; }
    }
}
