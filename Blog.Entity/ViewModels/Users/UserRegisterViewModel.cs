using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace Blog.Entity.ViewModels.Users
{
    public class UserRegisterViewModel
    {
        
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        public IFormFile ProfileImage { get; set; }


    }
}
