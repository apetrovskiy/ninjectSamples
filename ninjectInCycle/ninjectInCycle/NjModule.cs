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
    using Ninject.Extensions.NamedScope;
    using Ninject.Modules;
    
    /// <summary>
    /// Description of NjModule.
    /// </summary>
    public class NjModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMyObj>()
                .To<MyObj>()
                .InCallScope();
            
            Bind<Requester>()
                .ToSelf()
                .InSingletonScope();
        }
    }
}
