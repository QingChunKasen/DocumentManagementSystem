namespace Utilities
{
    using Castle.Windsor;

    public class IocContainerCache
    {
        private static readonly IWindsorContainer container = new WindsorContainer();
        public static IWindsorContainer Container
        {
            get { return container; }
        }
    }
}
