using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
	public static class ApplicationServiceRegistiration
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddMediatR(configuration =>
			{
				configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
			});

			return services;
		}
	}
}

