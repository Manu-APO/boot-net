using API.Services;
using Application.Common.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API;

public static class DependencyInjection
{
    public static IServiceCollection AddWebServices(this IServiceCollection services)
    {
        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddScoped<IUser, CurrentUser>();

        services.AddHttpContextAccessor();

        return services;
    }
}