﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoShop.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [ForeignKey("MembershipTypeId")]
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte? MembershipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}