using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AppiumDotNet.Fixture
{
    
    [CollectionDefinition("Appium")]
    public class CollectionFixture : ICollectionFixture<TestFixture>
    {
    }

}
