﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SharedTrip.Models
{
    public class User
    {
        public User()
        {
            this.UserTrips = new HashSet<UserTrip>();
            this.Id = Guid.NewGuid().ToString();
        }
        //•	Has an Id – a string, Primary Key
        //•	Has a Username – a string with min length 5 and max length 20 (required)
        //•	Has an Email - a string (required)
        //•	Has a Password – a string with min length 6 and max length 20  - hashed in the database(required)
        //•	Has UserTrips collection – a UserTrip type

        public string Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual ICollection<UserTrip> UserTrips { get; set; }
    }
}
