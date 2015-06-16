/*
 * Created by SharpDevelop.
 * User: alexa_000
 * Date: 28/04/2015
 * Time: 08:23 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace NinjectInterception
{
    using System;
    
    /// <summary>
    /// Description of MyClass03.
    /// </summary>
    public class MyClass03
    {
        string _data;
        
//        public MyClass03()
//        {
//            
//        }
        
        public MyClass03(string data)
        {
            _data = data + "_added";
        }
        
        public virtual void Test03()
        {
            Console.WriteLine("Test03: {0}", _data);
        }
    }
}
