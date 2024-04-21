﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Library_Management_System.Models
{
    public class User
    {
        [Required] 
        [PrimaryKey]
        public int UserID { get; set; } //autogenerated
        [Required]
        public string PIN { get; set; } //autogenerated from phone#
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public float Balance { get; set; }

        public User() 
        {
        
        }
        public User(int userID, string pin, string phoneNumber, string firstName, string lastName, string email, DateTime dOB, float balance)
        {
            UserID = userID;
            PIN = pin;
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DOB = dOB;
            Balance = balance;
        }
       
        public override string ToString()
        {
            return $"Phone Number: {PhoneNumber}, Name: {FirstName} {LastName}, Email: {Email} , DOB: {DOB}";
        }
    }
}
