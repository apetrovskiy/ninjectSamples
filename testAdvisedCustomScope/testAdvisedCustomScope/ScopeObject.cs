/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/25/2014
 * Time: 3:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace testAdvisedCustomScope
{
    using System;
    
    /// <summary>
    /// Description of ScopeObject.
    /// </summary>
    public class ScopeObject : IDisposable
    {
        public void DoSomething()
        {
            
        }
        
        public int GetSomething()
        {
            return 3;
        }
        
        public string SomeData { get; set; }
        
        public void Dispose()
        {
            
        }
    }
}
