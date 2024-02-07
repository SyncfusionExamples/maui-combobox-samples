using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DropDownCustomiztionSample
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Model>? countries;

        public event PropertyChangedEventHandler? PropertyChanged;

        private Model? selectedItem;
        public ObservableCollection<Model>? CountryCollection
        {
            get
            {
                return countries;
            }
            set
            {
                countries = value;
                OnPropertyChanged(nameof(CountryCollection));
            }
        }

        public Model? SelectedItem
        {
            get { return selectedItem; } set { selectedItem = value; OnPropertyChanged(nameof(SelectedItem));}
        }
        public void OnPropertyChanged([CallerMemberName] string? name = null) =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        public ViewModel()
        {
            this.CountryCollection = new ObservableCollection<Model>();

            CountryCollection.Add(new Model
            {
                CountryName = "India",
                MainCityName = "Delhi"
            });
            CountryCollection.Add(new Model
            {
                CountryName = "USA",
                MainCityName = "Washington"
            });
            CountryCollection.Add(new Model
            {
                CountryName = "France",
                MainCityName = "Paris"
            });
            CountryCollection.Add(new Model
            {
                CountryName = "Russia",
                MainCityName = "Moscow"
            });
            SelectedItem=CountryCollection.FirstOrDefault();
        }
    }

}
