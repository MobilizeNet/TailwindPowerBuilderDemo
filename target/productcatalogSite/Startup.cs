namespace WebSite
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Server.Kestrel.Core;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Configuration;
    using Mobilize.Web;
    using Mobilize.WebMap.Common.Core;
    using Mobilize.WebMap.Common.DCP;
    using Mobilize.WebMap.Host;
    using Mobilize.WebMap.Server;
    using Mobilize.WebMap.Server.ObservableBinder;
    using System.IO.Abstractions;

    /// <summary>
    /// Startup
    /// </summary>
    public partial class Startup
    {
        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// </summary>
        /// <param name="services">the collection of services</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddWebMap();
            services.AddRegistry();
            services.AddApplicationLauncher();
            services.RegisterModelMappers();
            services.RegisterWrappers();
            AddDesktopCompatibilityPlatform(services, Startup.Start);
            AddReportService(services);
            services.AddDistributedMemoryCache();
            services.AddSession(options => 
				{
					options.Cookie.Name = ".AspNetCore.Session-tailwindproductcatalog";
				}
			);
            services.AddAntiforgery(options => 
				{
					options.HeaderName = "tailwindproductcatalog-Xsrf-Header";
					options.FormFieldName = "tailwindproductcatalog-Xsrf-Cookie";
				}
			);
            services.AddMvc(options =>
            {
                options.ModelBinderProviders.Insert(0, new ObservableModelBinderProvider());
                options.ModelMetadataDetailsProviders.Insert(0, new SuppressChildValidationMetadataProvider(typeof(IObservable)));
            });
            services.AddSingleton<Mobilize.WebMap.Common.Server.ISortingActionService, Mobilize.Web.PB.Services.PbActionSortingService>();
            // If using IIS:
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
            // If using Kestrel:
            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
            services.AddHealthChecks();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        /// </summary>
        /// <param name="app">the application builder</param>
        /// <param name="env">the hosting environment</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAntiforgeryToken();
            app.UseWebMap();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("DefaultApi", "api/{controller}/{id}");
                endpoints.MapHealthChecks("/health");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }

        private static void AddDesktopCompatibilityPlatform(IServiceCollection services, EntryPoint entryPoint)
        {
            services.AddScoped<ICommandFactory, CommandFactory>();
            services.AddSingleton<IFileSystem, FileSystem>();
            services.AddScoped<Mobilize.WebMap.Common.DCP.IApplication>((provider) => new tailwindproductcatalog.Application(provider) { EntryPoint = entryPoint });
            var keyStorage = new CustomKeyDataStorage();
            var jsonStorage = new JsonStorage("appsettings.json");
            keyStorage.Register(new CookieBasedStorage());
            keyStorage.Register(jsonStorage);
            services.AddSingleton<Mobilize.WebMap.Common.Abstractions.Registry.IKeyDataStorage>(provider => keyStorage);
        }

        private void AddReportService(IServiceCollection services)
        {
            var url = Configuration.GetValue<string>("reportService");
            if (url == null)
            {
                url = "http://localhost:5011/ReportService.svc";
            }
            services.AddSingleton<Mobilize.Web.IReportService>(p => new ReportService.ReportServiceConnection(url));
        }
    }
}

