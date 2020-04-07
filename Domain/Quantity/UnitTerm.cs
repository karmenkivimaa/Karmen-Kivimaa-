using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity
{
    public sealed class UnitTerm : Entity<UnitData>
    {
        public UnitTerm(UnitTermData d) : this(null) { }
        public UnitTerm(UnitData data) : base(data) { }
    }

}

