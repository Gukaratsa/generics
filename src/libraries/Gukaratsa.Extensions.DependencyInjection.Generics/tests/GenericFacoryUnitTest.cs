using Gukaratsa.Extensions.DependencyInjection.Generics;
using Gukaratsa.Extensions.Generics;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;

namespace TestProject1
{
    public interface ITestInterface 
    {
        Guid Guid { get; }
    }

    public class TestClass : ITestInterface 
    {
        public Guid Guid { get; init; } = Guid.NewGuid();
    }


    public class GenericFacoryUnitTest
    {
        [Fact]
        public void CreateT_WhenCalled_ShouldReturnNewT()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IGenericFactory<ITestInterface, TestClass>>()
                .AddTransient(x => x.GetRequiredService<IGenericFactory<ITestInterface, TestClass>>().CreateInstance(""))
                .BuildServiceProvider();
        }
    }
}