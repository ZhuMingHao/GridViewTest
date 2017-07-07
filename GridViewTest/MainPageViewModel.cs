using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewTest
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<Phone> _items;
        public ObservableCollection<Phone> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }
        public MainPageViewModel()
        {
            var list = new ObservableCollection<Phone>();
            for (var i = 0; i < 1000; i++)
            {
                list.Add(new Phone { PhoneNumber = "123456" });
            }
            _items = list;
        }

    }
}
