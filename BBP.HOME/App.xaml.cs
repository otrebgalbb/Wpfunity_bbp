using CommonServiceLocator;
using Microsoft.Extensions.Logging;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Unity;
using System.Security.Principal;
using System.Windows;



namespace BBP.HOME.Boilerpate
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Views.MainWindow>();
        }

        /// <summary>
        /// Register all types
        /// </summary>
        /// <param name="containerRegistry">container registry</param>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance(System.Net.CredentialCache.DefaultNetworkCredentials);
            System.AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);

            // Logger
            containerRegistry.RegisterInstance<ILoggerFactory>(new NLog.Extensions.Logging.NLogLoggerFactory());

            // managers
            /*  containerRegistry.RegisterSingleton<IWorkspaceManager, WorkspaceManager>();
              containerRegistry.RegisterSingleton<IParameterManager, ParameterManager>();
              containerRegistry.RegisterSingleton<ILoadingHelper, LoadingHelper>();*/


        }

        /// <summary>
        /// Create the module catalog
        /// </summary>
        /// <returns>Instance of configuration module catalog</returns>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        /// <summary>
        /// Configure the view model locator
        /// </summary>
        protected override void ConfigureViewModelLocator()
        {
            // UnityBootstrapper
            ViewModelLocationProvider.SetDefaultViewModelFactory(type => Container.Resolve(type));
        }
    }
}
