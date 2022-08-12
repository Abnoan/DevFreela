using DevFreela.Application.Commands.CreateProject;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DevFreela.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) {
            services
                .AddMediatR(typeof(CreateProjectCommand));

            return services;
        }
       
    }
}