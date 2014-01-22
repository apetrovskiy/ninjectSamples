/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/22/2014
 * Time: 3:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace ninjectInCycle
{
    using System;
    
    /// <summary>
    /// Description of MyObj.
    /// </summary>
    public class MyObj : IMyObj
    {
        public virtual string Name { get; set; }
        
        public virtual void Dispose()
        {
            Name = string.Empty;
            GC.SuppressFinalize(this);
        }
    }
}
