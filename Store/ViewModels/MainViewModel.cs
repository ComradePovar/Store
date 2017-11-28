using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Store.Common;

namespace Store.ViewModels
{
    enum Tab { Clients, Orders };
    class MainViewModel : ViewModel
    {
        private Tab _selectedTab;
        public Tab SelectedTab
        {
            get
            {
                return _selectedTab;
            }
            set
            {
                if (SetProperty(ref _selectedTab, value))
                {

                }
            }
        }

        public MainViewModel()
        {
        }
    }
}
