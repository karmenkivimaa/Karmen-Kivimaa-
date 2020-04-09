﻿using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Pages.Quantity
{

    public abstract class MeasuresPage : CommonPage<IMeasureRepository, Measure, MeasureView, MeasureData>
    {

        protected internal MeasuresPage(IMeasureRepository r) : base(r)
        {
            PageTitle = "Measures";
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        protected internal override string getPageUrl() => "/Quantity/Measures";

        protected internal override Measure toObject(MeasureView view)
        {
            return MeasureViewFactory.Create(view);
        }

        protected internal override MeasureView toView(Measure obj)
        {
            return MeasureViewFactory.Create(obj);
        }

    }

}
