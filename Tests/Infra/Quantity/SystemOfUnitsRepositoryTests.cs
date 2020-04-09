using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Infra;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Abc.Tests.Infra.Quantity
{
    [TestClass]
    public class SystemOfUnitsRepositoryTests : RepositoryTests<SystemOfUnitsRepository, SystemOfUnits, SystemOfUnitsData>
    {

        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new QuantityDbContext(options);
            dbSet = ((QuantityDbContext)db).SystemsOfUnits;
            obj = new SystemOfUnitsRepository((QuantityDbContext)db);
            base.TestInitialize();
        }

        protected override Type getBaseType()
        {
            return typeof(UniqueEntityRepository<SystemOfUnits, SystemOfUnitsData>);
        }

        protected override string getId(SystemOfUnitsData d) => d.Id;

        protected override SystemOfUnits getObject(SystemOfUnitsData d) => new SystemOfUnits(d);

        protected override void setId(SystemOfUnitsData d, string id) => d.Id = id;

    }
}
