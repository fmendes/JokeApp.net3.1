using System;
using Microsoft.AspNetCore.Identity;
namespace JokeApp.net3._1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string userName { get; set; }

        public ApplicationUser()
        {
        }
    }
}
