using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.WebApp.ViewModels
{
    public class RolesForUserVM
    {
        public IdentityUser User { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public IList<string> AssignedRoles { get; set; }
        public IList<string> UnAssignedRoles { get; set; }
    }
}
