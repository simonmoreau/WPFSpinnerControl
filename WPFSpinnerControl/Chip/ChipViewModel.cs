using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFSpinnerControl.Chip
{
    class ChipViewModel : BindableBase
    {
        private ObservableCollection<FilterItem> _filterList;

        public ChipViewModel()
        {
            DeleteFilterItemCommand = new RelayCommand<FilterItem>(DeleteFilterItem);
            AddFilterItemCommand = new RelayCommand(AddFilterItem);

            List<FilterItem> filterItems = new List<FilterItem>();

            filterItems.Add(new FilterItem("Blue", "Blue", "#4287f5"));
            filterItems.Add(new FilterItem("Red", "Red", "#f54242"));
            filterItems.Add(new FilterItem("Green", "Green", "#42f566"));
            filterItems.Add(new FilterItem("Blue", "Blue", "#4287f5"));
            filterItems.Add(new FilterItem("Red", "Red", "#f54242"));
            filterItems.Add(new FilterItem("Green", "Green", "#42f566"));
            filterItems.Add(new FilterItem("Blue", "Blue", "#4287f5"));

            FilterList = new ObservableCollection<FilterItem>(filterItems);
        }

        private void AddFilterItem()
        {
            FilterList.Add(new FilterItem("Blue", "Blue", "#4287f5"));
        }

        private void DeleteFilterItem(FilterItem filterItem)
        {
            FilterList.Remove(filterItem);
        }

        public ObservableCollection<FilterItem> FilterList
        {
            get { return _filterList; }
            set { SetProperty(ref _filterList, value); }
        }

        public RelayCommand<FilterItem> DeleteFilterItemCommand { get; private set; }
        public RelayCommand AddFilterItemCommand { get; private set; }

    }

    public class FilterItem
    {
        public FilterItem(string name, string value, string color)
        {
            Name = name;
            Value = value;
            BrushConverter converter = new BrushConverter();

            Color = (Brush)converter.ConvertFromString(color);
        }

        public string Name { get; set; }
        public string Value { get; set; }
        public Brush Color { get; set; }
    }
}
