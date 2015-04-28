/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 4/28/2015
 * Time: 1:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace NinjectInterception
{
    using System;
    using Ninject.Modules;
    using Ninject.Extensions.Interception.Infrastructure.Language;
    
    /// <summary>
    /// Description of Module.
    /// </summary>
    public class MyModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<MyClass>().ToSelf().Intercept().With<ILoggerAspect>();
        }
    }
}
