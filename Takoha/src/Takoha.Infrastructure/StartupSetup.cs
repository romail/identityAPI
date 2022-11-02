using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Takoha.Infrastructure.Data;

namespace Takoha.Infrastructure;
public static class StartupSetup
{
  public static void AddDbContext(this IServiceCollection services, string connectionString) =>
      services.AddDbContext<AppDbContext>(options =>
          options.UseMySql(connectionString,new MySqlServerVersion(new Version(8, 0, 27))));
}
