using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Infra.Quantity {

    public sealed class SystemOfUnitsRepository : UniqueEntityRepository<SystemOfUnits, SystemOfUnitsData>,
        ISystemOfUnitsRepository {

        public SystemOfUnitsRepository() : this(null) { }
        public SystemOfUnitsRepository(QuantityDbContext c) : base(c, c?.SystemOfUnits) { }

        protected internal override SystemOfUnits ToDomainObject(SystemOfUnitsData d) => new SystemOfUnits(d);


    }

}

