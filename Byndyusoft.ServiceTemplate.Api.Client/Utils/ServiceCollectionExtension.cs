﻿namespace Byndyusoft.ServiceTemplate.Api.Client.Utils
{
    using Clients;
    using Interfaces;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Settings;

    public static class ServiceCollectionExtension
    {
        /// <summary>
        ///     Для работы клиенты необходимо указать настройки подключения к апи в appsetting
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddTemplateClient(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ITemplateClient, TemplateClient>();
            services.AddHttpClient<ITemplateClient, TemplateClient>();

            services.Configure<TemplateApiSettings>(configuration.GetSection(nameof(TemplateApiSettings)));
        }
    }
}