using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LyBooking.Data;
using System;

namespace LyBooking.Installer
{
    public class RepositoryInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        }
    }
}
