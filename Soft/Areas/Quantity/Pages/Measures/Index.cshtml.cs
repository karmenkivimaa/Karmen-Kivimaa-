﻿using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : SystemOfUnitsPage
    {

        public IndexModel(IMeasureRepository r) : base(r)
        {
        }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {

            await getList(sortOrder, currentFilter, searchString, pageIndex,
            fixedFilter, fixedValue);

        }


    }
}

