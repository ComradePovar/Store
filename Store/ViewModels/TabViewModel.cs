using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ViewModels
{
    class TabViewModel
    {
        public string Title { get; set; }

        public TabViewModel(string title = null)
        {
            Title = title;
        }
    }
}
