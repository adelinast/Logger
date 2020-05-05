namespace nsLogger
{
    public class Driver
    {
        public void SetServiceProvider(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private ServiceProvider _serviceProvider;
    }

    public class Application
    {
        private ServiceProvider _serviceProvider;

        public Application(ServiceProvider ServiceProvider)
        {
            _serviceProvider = ServiceProvider;
        }

        public void Run()
        {
            Driver driver = new Driver();
            driver.SetServiceProvider(_serviceProvider);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddService(new LoggerService());
            ServiceProvider serviceProvider = new ServiceProvider(serviceCollection);

            Application application = new Application(serviceProvider);
            application.Run();
        }
    }

}
