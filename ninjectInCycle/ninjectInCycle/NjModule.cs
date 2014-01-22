/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/22/2014
 * Time: 3:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace ninjectInCycle
{
    using System;
    using Ninject;
    using Ninject.Activation;
    using Ninject.Extensions.NamedScope;
    using Ninject.Modules;
    using Ninject.Parameters;
    using Ninject.Extensions.ChildKernel;
    
    /// <summary>
    /// Description of NjModule.
    /// </summary>
    public class NjModule : NinjectModule
    {
        public override void Load()
        {
            Bind<Requester>()
                .ToSelf()
                .InSingletonScope();
            
            Bind<IChildKernel>().ToSelf().InSingletonScope();
        }
    }
}
