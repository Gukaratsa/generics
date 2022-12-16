using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gukaratsa.Extensions.DependencyInjection.Generics
{
    public interface IGenericFactory<TInterface, TImplementation>
        where TImplementation : TInterface
    {
        TInterface CreateInstance(string InstanceName);
    }
}
