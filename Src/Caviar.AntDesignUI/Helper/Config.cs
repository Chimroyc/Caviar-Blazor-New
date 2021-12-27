﻿using AntDesign;
using Blazored.LocalStorage;
using Caviar.AntDesignUI.Helper;
using Caviar.SharedKernel;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;


namespace Caviar.AntDesignUI
{
    public static class Config
    {

        public static List<Assembly> AdditionalAssemblies;

        public static PathList PathList = new PathList();

        public static string TokenName { get; } = "authToken";

        public static IServiceCollection AddAdminCaviar(this IServiceCollection services, Type[] assemblies)
        {
            services.AddAntDesign();
            services.AddTransient<HttpHelper>();
            services.AddTransient<CavModal>();
            services.AddTransient<UserConfig>();
            services.AddTransient<ModalService>();
            services.AddTransient<MessageService>();
            services.AddSingleton<ILanguageService, InAssemblyLanguageService>();

            services.AddScoped<IPrismHighlighter, PrismHighlighter>();
            services.AddBlazoredLocalStorage();
            services.AddAuthorizationCore();
            services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            services.AddScoped<AuthService>();
            if (assemblies != null)
            {
                AdditionalAssemblies = new List<Assembly>();
                foreach (var item in assemblies)
                {
                    AdditionalAssemblies.Add(item.Assembly);
                }
            }
            return services;
        }
    }

    public class PathList
    {
        public string Home { get; set; } = "/";
        public string LoginPagePath { get; set; } = "/ApplicationUser/Login";

        public string MyDetails { get; set; } = "/ApplicationUser/MyDetails";

        public string UpdatePwd { get; set; } = "/ApplicationUserUpdatePwd";

        public string GetApiList { get; set; } = "SysMenu/GetApiList";
    }
}
