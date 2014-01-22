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
    /// Description of IMyObj.
    /// </summary>
    public interface IMyObj : IDisposable
    {
        string Name { get; set; }
    }
}
