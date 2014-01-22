/*
 * Created by SharpDevelop.
 * User: APetrovsky
 * Date: 1/22/2014
 * Time: 5:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace ninjectInCycle
{
    using System;
    using Ninject;
    using Ninject.Extensions.NamedScope;
    using Ninject.Modules;
    
    /// <summary>
    /// Description of NjChildKernelModule.
    /// </summary>
    public class NjChildKernelModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMyObj>()
                .To<MyObj>()
                .InCallScope();
        }
    }
}
