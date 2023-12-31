﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using P04WeatherForecastAPI.Client.ViewModels;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.FilmService;
using P12MAUI.Client.MessageBox;
using P12MAUI.Client.ViewModels;

namespace P12MAUI.Client
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif


            ConfigureServices(builder.Services);
            return builder.Build();
        }


        private static void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = ConfigureAppSettings(services);
            ConfigureAppServices(services, appSettingsSection);
            ConfigureViewModels(services);
            ConfigureViews(services);
            ConfigureHttpClients(services, appSettingsSection);
        }

        private static AppSettings ConfigureAppSettings(IServiceCollection services)
        {
            // pobranie appsettings z konfiguracji i zmapowanie na klase AppSettings 
            //Microsoft.Extensions.Options.ConfigurationExtensions
            //var appSettings = _configuration.GetSection(nameof(AppSettings));
            //var appSettingsSection = appSettings.Get<AppSettings>();
            // services.Configure<AppSettings>(appSettings);
            var appSettingsSection = new AppSettings()
            {
                BaseAPIUrl = "http://localhost:5093",
                //BaseAPIUrl = "https://alxshopapi.azurewebsites.net",
                BaseFilmEndpoint = new BaseFilmEndpoint()
                {
                    Base_url = "api/Film/",
                    GetAllFilmsEndpoint = "",
                },
            };
            services.AddSingleton(appSettingsSection);

            return appSettingsSection;
        }

        private static void ConfigureAppServices(IServiceCollection services, AppSettings appSettings)
        {
            services.AddSingleton<IConnectivity>(Connectivity.Current);
            services.AddSingleton<IGeolocation>(Geolocation.Default);
            services.AddSingleton<IMap>(Map.Default);

            // konfiguracja serwisów 
            services.AddSingleton<IFilmService, FilmService>();
            services.AddSingleton<IMessageDialogService, MauiMessageDialogService>();
          
        }

        private static void ConfigureViewModels(IServiceCollection services)
        {

            // konfiguracja viewModeli 
           
        
            services.AddSingleton<FilmsViewModel>();
            services.AddTransient<FilmDetailsViewModel>();
          
            // services.AddSingleton<BaseViewModel,MainViewModelV3>();
        }

        private static void ConfigureViews(IServiceCollection services)
        {
            // konfiguracja okienek 
            services.AddSingleton<MainPage>();    
            services.AddTransient<FilmDetailsView>();
        }

        private static void ConfigureHttpClients(IServiceCollection services, AppSettings appSettingsSection)
        {
            var uriBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
            {
                Path = appSettingsSection.BaseFilmEndpoint.Base_url,
            };
            //Microsoft.Extensions.Http
            services.AddHttpClient<IFilmService, FilmService>(client => client.BaseAddress = uriBuilder.Uri);
        }
    }
}