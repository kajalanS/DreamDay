using DreamDay.Data;
using DreamDay.Models;
using DreamDay.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DreamDay.Extensions
{
    public enum ConnectionType
    {
        SqlServer,
        MySql,
    }

    public static class CustomServiceExtension
    {
        public static void ConfigureCustomRoleServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<User, Role>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders();
            services.AddControllersWithViews();
            services.AddRazorPages();


            // builder.Services.AddIdentity<User, Role>(options => options.SignIn.RequireConfirmedAccount = true)
            //     .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            // builder.Services.AddRazorPages();
        }

        public static void ConfigureGmailServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            IConfigurationSection config = configuration.GetSection("GmailSettings");
            services.Configure<GmailSettings>(config);
            services.AddTransient<IEmailSender, GmailSender>();
        }

        public static void ConfigureMailTrapServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            IConfigurationSection config = configuration.GetSection("MailTrap");
            services.Configure<GmailSettings>(config);
            services.AddTransient<IEmailSender, MailTrapMailSender>();
        }

        public static void ConfigureDatabaseServices(this IServiceCollection services, ConfigurationManager configuration, ConnectionType connectionType)
        {
            if (connectionType == ConnectionType.SqlServer)
            {
                var connectionString = configuration.GetConnectionString("SqlConnectionString") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(connectionString));
                services.AddDatabaseDeveloperPageExceptionFilter();
            }
            else
            {
                var connectionString = configuration.GetConnectionString("MySqlConnectionString") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
                services.AddDbContext<ApplicationDbContext>(option =>
                {
                    var serverVersion = new MySqlServerVersion(new Version(8, 0, 41));
                    option.UseMySql(connectionString, serverVersion);
                });
                services.AddDatabaseDeveloperPageExceptionFilter();
            }
        }
    }
}
