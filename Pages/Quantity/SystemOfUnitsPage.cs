using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Abc.Pages.Quantity 
{

    public class SystemOfUnitsPage : CommonPage<ISystemOfUnitsRepository, SystemOfUnits, SystemOfUnitsView, SystemOfUnitsData>
    {

        protected internal SystemOfUnitsPage(ISystemOfUnitsRepository r) : base(r) 
        {
            PageTitle = "System Of Units";
        }

        public override string ItemId => Item.Id;

        protected internal override string getPageUrl() => "/Quantity/SystemOfUnits";

        protected internal override SystemOfUnits toObject(SystemOfUnitsView view) 
        {
            return SystemOfUnitsViewFactory.Create(view);
        }

        protected internal override SystemOfUnitsView toView(SystemOfUnits obj) 
        {
            return SystemOfUnitsViewFactory.Create(obj);
        }

    }

}


