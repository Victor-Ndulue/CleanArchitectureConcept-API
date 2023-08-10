using AutoMapper;
using CleanArchitectureConcept_Application.Services.Implementations;
using CleanArchitectureConcept_Application.Services.Interfaces;
using CleanArchitectureConcept_Infrastructure.UOW;
using Serilog.Core;

namespace CleanArchitectureConcept_API.Extension
{
    public static class ServiceExtension
    {
        public static void ConfigureDependencyInjection(this IServiceCollection services) 
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICompanyService, CompanyService>();
        }    
    }
}
