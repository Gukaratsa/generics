using Gukaratsa.Extensions.DependencyInjection.Generics;
using System.Runtime.CompilerServices;

namespace Gukaratsa.Extensions.Generics
{
    public class GenericFactory<TInterface, TImplementation> : IGenericFactory<TInterface, TImplementation>
        where TImplementation : TInterface
    {
        private readonly Dictionary<string, TInterface> _instances = new();

        public GenericFactory() 
        {

        }

        public TInterface CreateInstance(string InstanceName)
        {
            if (!_instances.ContainsKey(InstanceName))
                _instances.Add(InstanceName, Activator.CreateInstance<TImplementation>());
            return _instances[InstanceName];
        }
    }
}