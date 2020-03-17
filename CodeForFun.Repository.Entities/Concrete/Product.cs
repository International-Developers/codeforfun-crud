﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeForFun.Core.Entities;

namespace CodeForFun.Repository.Entities.Concrete
{
    public partial class Product : IEntity
    {
        public Product()
        {
            ProductsToCustomers = new HashSet<ProductsToCustomer>();
        }

        [Key]
        public int Id { get; set; }
        public Int16 CategoryId { get; set; }
        [StringLength(16)]
        public string Code { get; set; }
        [StringLength(32)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column("Date_Register", TypeName = "smalldatetime")]
        public DateTime DateRegister { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Products")]
        public virtual Category Category { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ProductDetail ProductDetail { get; set; }
        [InverseProperty(nameof(ProductsToCustomer.Product))]
        public virtual ICollection<ProductsToCustomer> ProductsToCustomers { get; set; }
    }
}