    using CommunityToolkit.Mvvm.ComponentModel;
    using CommunityToolkit.Mvvm.Input;
    using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace ML_Calculate.ViewModel
{
   

      public partial class MainViewModel : ObservableObject
        {
        public MainViewModel()
        {
            Items = [];
        }

            [ObservableProperty]

            ObservableCollection<string> items;

            [ObservableProperty]
            string text;

            public object MymodelList { get; private set; }

            [RelayCommand]
            void Add()
            {
                if (string.IsNullOrWhiteSpace(Text))
                    return;

                Items.Add(Text);

                Text = string.Empty;

            }

            [RelayCommand]
            void Delete(string s)
        {
            if (!Items.Contains(s))
            {
                return;
            }
            Items.Remove(s);

        }
        [RelayCommand]
            void Reset()
            {
                Items.Clear();
            }

           
        }
}


