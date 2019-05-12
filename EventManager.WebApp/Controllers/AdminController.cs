using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManager.WebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EventManager.WebApp.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        //public RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager )
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
        }
        // GET: Admin
        public ActionResult IndexUsers()
        {
            var users = _userManager.Users;

            return View(users);
        }
        public ActionResult IndexRoles()
        {
           var roles = _roleManager.Roles;
            return View(roles);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        [HttpGet]
        public ActionResult CreateRole()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateRole(AddRoleVM addRoleVM)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid) return View(addRoleVM);
                var role = new IdentityRole
                {
                    Name = addRoleVM.RoleName
                };
                IdentityResult result = await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("IndexRoles", _roleManager.Roles);
                }
                return RedirectToAction(nameof(IndexUsers));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> AddRoleToUser(string userId)
        {
            IdentityUser user = new IdentityUser();

            if (!String.IsNullOrEmpty(userId))
            {
                user = await _userManager.FindByIdAsync(userId);
            }

            if (user == null)
                return RedirectToAction("IndexRoles", _roleManager.Roles);

            // Reeds toegekende rollen
            var assignRolesToUserViewModel = new RolesForUserVM()
            {
                AssignedRoles = await _userManager.GetRolesAsync(user),
                UnAssignedRoles = new List<string>(),
                User = user,
                UserId = userId
            };

            // Nog niet toegekende rollen
            foreach (var identityRole in _roleManager.Roles)
            {
                if (!await _userManager.IsInRoleAsync(user, identityRole.Name))
                {
                    assignRolesToUserViewModel.UnAssignedRoles.Add(identityRole.Name);
                }
            }
            return View(assignRolesToUserViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddRoleToUser(RolesForUserVM rolesForUserViewModel)
        {
            var user = await _userManager.FindByIdAsync(rolesForUserViewModel.UserId);
            var role = await _roleManager.FindByNameAsync(rolesForUserViewModel.RoleName);

            var result = await _userManager.AddToRoleAsync(user, role.Name);

            if (result.Succeeded)
            {
                return RedirectToAction("IndexUsers", _userManager.Users);
            }
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return View(user);
        }
        // POST: Admin/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IdentityUser user)
        {
            try
            {
                var rolesForUser = await _userManager.GetRolesAsync(user);

                if(rolesForUser.Count()> 0)
                {
                    foreach(var item in rolesForUser.ToList())
                    {
                        //var result = await _userManager.RemoveFromRoleAsync(user, item);
                    }
                }
                await _userManager.DeleteAsync(user);
                return RedirectToAction(nameof(IndexUsers));
            }
            catch
            {
                return View();
            }
        }
    }
}