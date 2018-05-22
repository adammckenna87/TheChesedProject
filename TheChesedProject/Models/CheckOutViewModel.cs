﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheChesedProject.Models
{
    public class CheckOutViewModel
    {

        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }


        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string ShippingAddressLine1 { get; set; }

        [Required]
        [Display(Name = "Address Line 2")]
        public string ShippingAddressLine2 { get; set; }

        [Required]
        [Display(Name = "Zipcode")]
        public string ShippingZip { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string BillingAddressLine1 { get; set; }

        [Required]
        [Display(Name = "Address Line 2")]
        public string BillingAddressLine2 { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Name On Card")]
        public string NameOnCard { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        [Required]
        [Display(Name = "Expiry")]
        public string ExpirationDate { get; set; }

        [Required]
        [Display(Name = "CVV")]
        public string CVV { get; set; }

        [Required]
        [Display(Name = "Zipcode")]
        public string Zipcode { get; set; }


    }
}