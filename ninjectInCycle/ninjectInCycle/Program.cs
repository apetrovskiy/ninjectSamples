/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/22/2014
 * Time: 3:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace ninjectInCycle
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Ninject;
    using Ninject.Parameters;
    using Ninject.Extensions.ChildKernel;
    
    class Program
    {
        public static IKernel Kernel;
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello NInject!");
            
            // TODO: Implement Functionality Here
            
            Kernel = new StandardKernel(new NjModule());
            Kernel.Settings.ActivationCacheDisabled = true;
            
            var requester = Kernel.Get<Requester>();
            
            for (int i = 0; i < 100000000; i++) {
                
                var childKernel = new ChildKernel(Kernel, new NjChildKernelModule());
                childKernel.Settings.ActivationCacheDisabled = true;
                
                List<IMyObj> list =
                    requester.RequestObjects(childKernel);
                
                foreach (MyObj listItem in list) {
                    listItem.Dispose();
                }
                list.Clear();
                list = null;
                
                childKernel.Dispose();
            }
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}