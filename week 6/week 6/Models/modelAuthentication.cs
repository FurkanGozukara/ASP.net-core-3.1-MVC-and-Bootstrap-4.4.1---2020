using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week_6.Models
{
    public class modelAuthentication
    {
        private readonly UserManager<CustomClasses.CustomUser> _userManager;
        public modelAuthentication(
    UserManager<CustomClasses.CustomUser> userManager)
        {
            _userManager = userManager;
        }

        public void setAuth(CustomClasses.CustomUser myUser)
        {
            _userManager.CreateAsync(myUser);
        }
    }
}
