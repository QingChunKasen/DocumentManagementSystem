namespace Utilities
{
    using Castle.MicroKernel.Registration;
    using Castle.Windsor.Installer;
    using System.Collections.Generic;
    using System.Reflection;

    public class IocContainerBootstrap
    {
        public void Setup(params Assembly[] assemblies)
        {
            var installers = new List<IWindsorInstaller> { Configuration.FromAppConfig() };
            if (assemblies != null && assemblies.Length > 0)
            {
                foreach(var a in assemblies)
                {
                    installers.Add(FromAssembly.Instance(a));
                }
            }
            IocContainerCache.Container.Install(installers.ToArray());
        }
    }
}
