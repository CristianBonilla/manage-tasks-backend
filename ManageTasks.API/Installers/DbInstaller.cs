using Microsoft.EntityFrameworkCore;
using ManageTasks.Domain.Context;

namespace ManageTasks.API.Installers
{
  class DbInstaller : IInstaller
  {
    public void InstallServices(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
    {
      string connectionString = configuration.GetConnectionString(CommonValues.ManageTasksConnection)!;
      services.AddDbContextPool<ManageTasksContext>(options => options.UseSqlServer(connectionString));
      //services.AddSqlServer<ManageTasksContext>(connectionString);
    }
  }
}
