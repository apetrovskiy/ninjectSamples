/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/22/2014
 * Time: 3:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace ninjectInCycle
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Ninject;
    using Ninject.Extensions.ChildKernel;
    
    /// <summary>
    /// Description of Requester.
    /// </summary>
    public class Requester
    {
        public List<IMyObj> RequestObjects(IChildKernel childKernel)
        {
            List<IMyObj> list = new List<IMyObj>();
            
            for(int i = 0; i < 10; i++) {
                var myObj = childKernel.Get<IMyObj>();
                myObj.Name = "abcdefghijklmnopqrstuvwxyz";
                list.Add(myObj);
            }
            
            return list;
        }
    }
}
