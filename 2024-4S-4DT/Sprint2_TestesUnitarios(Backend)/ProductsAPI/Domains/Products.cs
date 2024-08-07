﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAPI.Domains
{
    [Table(nameof(Products))]
    public class Products
    {
        [Key]
        public Guid IdProduct { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public String Name { get; set; }

        [Column(TypeName = "DECIMAL()")]
        public decimal Price { get; set; }
        
    }
}
