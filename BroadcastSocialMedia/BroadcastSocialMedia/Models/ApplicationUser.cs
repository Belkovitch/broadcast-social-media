﻿using Microsoft.AspNetCore.Identity;

namespace BroadcastSocialMedia.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public ICollection<Broadcast> Broadcasts { get; set; }
    }
}
