﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeForFun.Core.Entities;

namespace CodeForFun.Repository.Entities.Concrete
{
    public partial class Customer : IEntity
    {
        public Customer()
        {
            ProductsToCustomers = new HashSet<ProductsToCustomer>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(24)]
        public string Name { get; set; }
        [StringLength(24)]
        public string Surname { get; set; }

        [InverseProperty(nameof(ProductsToCustomer.Customer))]
        public virtual ICollection<ProductsToCustomer> ProductsToCustomers { get; set; }
    }
}