﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Lesson06.Models
{
        public class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Country { get; set; }
        }
}
