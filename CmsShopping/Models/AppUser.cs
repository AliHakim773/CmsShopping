﻿using Microsoft.AspNetCore.Identity;

namespace CmsShopping.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}
