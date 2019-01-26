using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyBeerApp.IntegrationTests
{
    [CollectionDefinition(Constants.WEB_DATABASE_FIXTURE)]
    public class WebTestDatabaseCollection : ICollectionFixture<WebTestDatabaseFixture>
    {
    }
}
