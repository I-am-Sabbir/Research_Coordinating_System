using Autofac;
using Framework.Repositories;
using Framework.Services;
using Membership;
using Membership.Contexts;
using Membership.Data;
using Membership.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;

namespace Framework
{
    public class FrameworkModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FrameworkModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrameworkContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<FrameworkUnitOfWork>().As<IFrameworkUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<MembershipUnitOfWork>().As<IMembershipUnitOfWork>()
                .InstancePerLifetimeScope();
            
            builder.RegisterType<AccountSeed>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UserService>().As<IUserService>()
              .InstancePerLifetimeScope();

            builder.RegisterType<CurrentUserService>().As<ICurrentUserService>()
           .InstancePerLifetimeScope();

            //Repositories
            builder.RegisterType<PaperCategoryRepository>().As<IPaperCategoryRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PaperDetailsRepository>().As<IPaperDetailsRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResearchCollaborationRepository>().As<IResearchCollaborationRepository>()
                .InstancePerLifetimeScope();
            
            builder.RegisterType<ResearchSeminarRepository>().As<IResearchSeminarRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TaskRepository>().As<ITaskRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<MembershipRepository>().As<IMembershipRepository>()
                .InstancePerLifetimeScope();

            //Services
            builder.RegisterType<PaperCategoryService>().As<IPaperCategoryService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PaperDetailsService>().As<IPaperDetailsService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResearchCollaborationService>().As<IResearchCollaborationService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResearchSeminarService>().As<IResearchSeminarService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TaskService>().As<ITaskService>()
                .InstancePerLifetimeScope();


            base.Load(builder);
        }
    }
}
