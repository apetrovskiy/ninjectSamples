/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/25/2014
 * Time: 3:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace testAdvisedCustomScope
{
    using System;
    using Xunit;
    using Xunit.Extensions;
    using Ninject;
    using Ninject.Activation;
    using Ninject.Components;
    using Ninject.Modules;
    using Ninject.Parameters;
    using Ninject.Planning;
    using Ninject.Syntax;
    
    /// <summary>
    /// Description of CustomScopeTestFixture.
    /// </summary>
    public class CustomScopeTestFixture
    {
        public class TestService { }
        
        [Fact]
        public static void Test()
        {
            var kernel = new StandardKernel();
            kernel.Bind<ScopeObject>().ToSelf().InScope( x => ProcessingScope.Current );
            
            var scopeA = new ScopeObject();
            var scopeB = new ScopeObject();
            
            ProcessingScope.Current = scopeA;
            var testA1 = kernel.Get<ScopeObject>();
            var testA2 = kernel.Get<ScopeObject>();
            
            Assert.Same( testA2, testA1 );
            
            ProcessingScope.Current = scopeB;
            var testB = kernel.Get<ScopeObject>();
            
            Assert.NotSame( testB, testA1 );
            
            ProcessingScope.Current = scopeA;
            var testA3 = kernel.Get<ScopeObject>();
            
            Assert.Same( testA3, testA1 );
            
            
            
            Assert.NotNull(testA1);
            Assert.NotNull(testA2);
            Assert.NotNull(testA3);
            Assert.NotNull(testB);
            testA1 = null;
            kernel.Release(testA2);
            testA3.Dispose();
            kernel.Dispose();
            Assert.Null(testA1);
            Assert.Null(testA2);
            Assert.Null(testA3);
            Assert.Null(testB);
            
            // Assert.
        }
    }
}
