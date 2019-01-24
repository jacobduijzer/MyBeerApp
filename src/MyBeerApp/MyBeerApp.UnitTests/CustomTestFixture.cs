using Microsoft.EntityFrameworkCore;
using MyBeerApp.Infrastructure.Shared;
using System;

namespace MyBeerApp.UnitTests
{
    public class CustomTestFixture : IDisposable
    {
        public readonly DbContextOptions<MyBeerAppContext> dbContextOptions;

        public CustomTestFixture()
        {
            dbContextOptions = new DbContextOptionsBuilder<MyBeerAppContext>()
                .UseInMemoryDatabase(databaseName: "test_inmem_database")
                .Options;
        }

        public void Dispose()
        {
        }
    }
}