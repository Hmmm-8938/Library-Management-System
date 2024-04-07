﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public abstract class User
    {
        public int UserID { get; set; } //autogenerated
        public string PIN { get; set; } //autogenerated from phone#
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateOnly DOB { get; set; }
        public float Balance { get; set; }

        public User(string phoneNumber, string firstName, string lastName, string email, DateOnly dOB)
        {
            //PIN generated here?
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DOB = dOB;
            Balance = 0;
        }

        public override string ToString()
        {
            return $"Phone Number: {PhoneNumber}, Name: {FirstName} {LastName}, Email: {Email}, DOB: {DOB}";
        }
    }
}
