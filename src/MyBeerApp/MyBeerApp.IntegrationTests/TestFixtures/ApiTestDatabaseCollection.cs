using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MyBeerApp.IntegrationTests.TestFixtures
{
    [CollectionDefinition(Constants.API_DATABASE_FIXTURE)]
    public class ApiTestDatabaseCollection : ICollectionFixture<ApiTestDatabaseFixture>
    {
    }
}
