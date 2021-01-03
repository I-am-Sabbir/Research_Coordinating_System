using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Membership.Entities;
using Research_Coordinating_System.Areas.Admin.Models.AssignCoordinator;
using Research_Coordinating_System.Models.Paper;
using Autofac;

namespace Research_Coordinating_System
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AssignModel>();
            builder.RegisterType<PaperModel>();

            

            base.Load(builder);
        }
    }
}
