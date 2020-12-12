using Autofac;
using Framework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using Research_Coordinating_System.Models;

namespace Research_Coordinating_System.Areas.Coordinator.Models
{
    public abstract class CoordinatorBaseModel
    {
        public MenuModel MenuModel { get; set; }

        protected IHttpContextAccessor _httpContextAccessor;
        public ResponseModel Response
        {
            get
            {
                if (_httpContextAccessor.HttpContext.Session.IsAvailable
                    && _httpContextAccessor.HttpContext.Session.Keys.Contains(nameof(Response)))
                {
                    var response = _httpContextAccessor.HttpContext.Session.Get<ResponseModel>(nameof(Response));
                    _httpContextAccessor.HttpContext.Session.Remove(nameof(Response));

                    return response;
                }
                else
                    return null;
            }
            set
            {
                _httpContextAccessor.HttpContext.Session.Set(nameof(Response),
                    value);
            }
        }

        public CoordinatorBaseModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            SetupMenu();
        }

        public CoordinatorBaseModel()
        {
            _httpContextAccessor = Startup.AutofacContainer.Resolve<IHttpContextAccessor>();
            SetupMenu();
        }

        private void SetupMenu()
        {
            MenuModel = new MenuModel
            {
                MenuItems = new List<MenuItem>
                {
                    new MenuItem
                    {
                        Title = "Register Faculty",
                        url = ""

                    },

                    new MenuItem
                    {
                        Title = "Task",
                        url = ""

                    },

                    new MenuItem
                    {
                        Title = "View Paper Report",
                        url = ""

                    },

                    new MenuItem
                    {
                        Title = "Log Out",
                        url= ""

                    }
                }
            };

        }

    }
}
