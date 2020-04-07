using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Facade.Quantity
{
    public static class SystemOfUnitsViewFactory
    {
        public static SystemOfUnits Create(SystemOfUnitsView view)
        {
            var d = new SystemOfUnitsData();
            Copy.Members(view, d);

        }

        internal static object Create(SystemOfUnits systemOfUnits)
        {
            throw new NotImplementedException();
        }
    }
}
