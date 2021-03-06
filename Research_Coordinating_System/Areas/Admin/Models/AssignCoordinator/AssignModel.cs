﻿using Membership.Services;
using Research_Coordinating_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Areas.Admin.Models.AssignCoordinator
{
    public class AssignModel : AssignBaseModel
    {
        public AssignModel(IUserService userService) : base(userService) { }

        public AssignModel() : base() { }

        internal object GetUsers(DataTablesAjaxRequestModel dataTables)
        {
            var data = _userService.GetAllMembersAsync(
                                    dataTables.PageIndex,
                                    dataTables.PageSize,
                                    dataTables.SearchText,
                                    dataTables.GetSortText(new string[] { "Email", "Id" }));
            return new
            {
                rerecordsTotal = data.total,
                recordsFiltered = data.totalFiltered,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Email,
                                record.Id.ToString()
                                

                        }
                   ).ToArray()

            };
        }
    }
}
