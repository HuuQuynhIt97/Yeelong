using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LyBooking.Installer
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
