using Research_Coordinating_System.Areas.Admin.Models;
using Research_Coordinating_System.Areas.Coordinator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models
{
    public class LeftMenuModel
    {
        //public AdminBaseModel AdminBaseModel { get; set; }
        //public CoordinatorBaseModel CoordinatorBaseModel { get; set; }
        public MenuModel MenuModel { get; private set; }
        public LeftMenuModel()
        {
            MenuModel = new MenuModel();
        }
    }
}
