using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gukaratsa.Extensions.DependencyInjection.Generics
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGenericFactory<TInterface, TImplementation>(this IServiceCollection services)
        {

            return services;
        }
    }
}
