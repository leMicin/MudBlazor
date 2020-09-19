﻿using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace MudBlazor
{
    public partial class MudTablePager : ComponentBase
    {
        [CascadingParameter] public MudTable Table { get; set; }
        [Parameter] public bool DisabelRowsPerPage { get; set; }

        [Parameter] public List<int> RowsPerPage { get; set; } = new List<int>() { 10, 25, 50, 100 };

        private void SetRowsPerPage(string size)
        {
            Table.SetRowsPerPage(int.Parse(size));
        }
    }
}