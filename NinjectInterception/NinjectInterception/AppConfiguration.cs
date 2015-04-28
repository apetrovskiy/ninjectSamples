/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 4/28/2015
 * Time: 1:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace NinjectInterception
{
    using System;
    using Ninject;
    using Ninject.Extensions.Interception.Infrastructure.Language;
    using Ninject.Extensions.Conventions;
    
    /// <summary>
    /// Description of AppConfiguration.
    /// </summary>
    class AppConfiguration 
    {
    
        internal AppConfiguration( )
        {
            // var settings = new NinjectSettings() { LoadExtensions = false };
            // Kernel = new StandardKernel(settings);
            Kernel = new StandardKernel();
            Load();
        }
    
        internal StandardKernel Kernel { get; set; }
    
        public static AppConfiguration Instance
        {
            get { return _instance ?? (_instance = new AppConfiguration()); }
        }
    
        static AppConfiguration _instance;
    
        void Load()
        {
            // Kernel.Bind<ILoggerAspect>().To<Log4NetAspect>().InSingletonScope();
            // Kernel.Bind<MyClass>().ToSelf().Intercept().With<ILoggerAspect>();
            Kernel.Bind(convention => convention
                        .FromAssembliesMatching("*.exe")
                        .SelectAllClasses()
                        // .BindAllInterfaces()
                        .BindToSelf()
                        .Configure(x => x
                                   .InSingletonScope()
                                   .Intercept()
                                   // .With<ILoggerAspect>()));
                                   .With<Log4NetAspect>()));
        }
    
        internal static StandardKernel Resolver()
        {
            return Instance.Kernel;
        }
    }
}
