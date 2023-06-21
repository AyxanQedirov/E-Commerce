using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessDependencyResolver
    {
        public static IServiceCollection AddBusinessLayerDependencies(this IServiceCollection services)
        {
            return services;
        }
    }
}
