using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LyBooking.Helpers;
using LyBooking.Services;

namespace LyBooking.Installer
{
    public class ServiceInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IMailingService, MailingService>();
            services.AddScoped<IAccountPermissionService, AccountPermissionService>();
            services.AddScoped<IAccountRoleService, AccountRoleService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddScoped<IMethodService, MethodService>();
            services.AddScoped<ISystemLanguageService, SystemLanguageService>();
            services.AddScoped<IPermissionService, PermissionService>();

            services.AddScoped<IRoomService, RoomService>();

            services.AddScoped<IXAccountService, XAccountService>();
            services.AddScoped<IXAccountGroupService, XAccountGroupService>();
            services.AddScoped<ISysMenuService, SysMenuService>();

            services.AddScoped<IReportService, ReportService> ();

            services.AddScoped<ICustomerService, CustomerService>();
           
            services.AddScoped<ICodePermissionService, CodePermissionService>();

            services.AddScoped<IReportConfigService, ReportConfigService>();

           
            services.AddScoped<IStoredProcedureService, StoredProcedureService>();
            services.AddScoped<ICodeTypeService, CodeTypeService>();
            services.AddScoped<IDashboardService, DashboardService>();
            services.AddScoped<ISystemConfigService, SystemConfigService>();

            services.AddScoped<IHallService, HallService>();
            services.AddScoped<ISiteService, SiteService>();
            services.AddScoped<IWorkOrderService, WorkOrderService>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<ISequenceService, SequenceService>();


            services.AddScoped<IChemicalService, ChemicalService>();
            services.AddScoped<IGluesService, GluesService>();
            services.AddScoped<IShoeService, ShoeService>();
            services.AddScoped<IGlueChemicalService, GlueChemicalService>();
            services.AddScoped<IShoeGlueService, ShoeGlueService>();
        }
    }
}
