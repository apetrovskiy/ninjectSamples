/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/25/2014
 * Time: 3:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace testAdvisedCustomScope
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // TODO: Implement Functionality Here
            
            CustomScopeTestFixture.Test();
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}