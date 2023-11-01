﻿using Microsoft.Extensions.DependencyInjection;
using PerfectlyMadeInc.WebEx.Accounts.Data;
using PerfectlyMadeInc.WebEx.Authentication;
using PerfectlyMadeInc.WebEx.Contract.Accounts;

namespace PerfectlyMadeInc.WebEx.Accounts
{
    public static class AccountServiceCollectionExtensions
    {
        public static IServiceCollection AddAccountServices(this IServiceCollection services)
        {
            services.AddSingleton<IAuthentication, AuthenticationService>();
            services.AddSingleton<IAccountAdministration, AccountAdministration>();
            services.AddSingleton<IAccountDatabaseLayer, AccountDatabaseLayer>();
            return services;
        }
    }
}
