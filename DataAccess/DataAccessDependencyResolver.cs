using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessDependencyResolver
    {

        public static IServiceCollection AddDataAccessLayerDependencies(this IServiceCollection services)
        {
            return services;
        }
    }
}
