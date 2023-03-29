using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Journal2._0.ViewModel.Base;

namespace Journal2._0.ViewModels
{
    internal class MainWindowViewModel: BaseViewModel
    {
        protected string _title;

        public string Title 
        { 
            get => _title; 
            set => Set(ref _title, value);
        }
    }
}
