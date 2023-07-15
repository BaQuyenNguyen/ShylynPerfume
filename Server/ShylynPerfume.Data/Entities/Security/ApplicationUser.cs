﻿using System.ComponentModel.DataAnnotations;

namespace ShylynPerfume.Data.Entities
{
    public class ApplicationUser
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
