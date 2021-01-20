using Membership.Entities;
using Membership.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Areas.Admin.Models.AssignCoordinator
{
    public class EditAssignModel : AssignBaseModel
    {
        public string Email { get; set; }
        public Guid UserId { get; set; }
        public string Role { get; set; }

        internal void Load(Guid id)
        {
            var user = _userService.GetById(id);

            if (user != null)
            {
                UserId = user.Id;
                Email = user.Email;

            }
        }

        public void Edit()
        {
            var user = new ApplicationUser()
            {
                Id = this.UserId,
               Email = this.Email 
            };
            string roleName = "Coordinator";
            _userService.Update(user, roleName);
        }

        //public IList<SelectListItem> GetRoleList()
        //{
        //    IList<SelectListItem> listItems = new List<SelectListItem>();

        //    foreach (var item in _userService.Update())
        //    {
        //        var ctg = new SelectListItem
        //        {
        //            Text = item.Name,
        //            Value = item.Id.ToString()
        //        };
        //        listItems.Add(ctg);
        //    }
        //    return listItems;
        //}
    }
}
