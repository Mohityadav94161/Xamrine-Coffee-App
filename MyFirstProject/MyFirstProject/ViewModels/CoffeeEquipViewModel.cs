using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewModels
{
    public class CoffeeEquipViewModel:BindableObject
    {
        public CoffeeEquipViewModel() {
            IncreaseCount = new Command(IncreaseCountCommand);
        }
        String countDisplay;
        public String CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay) return;
                countDisplay = value;
                OnPropertyChanged();
            }
        }
        int count = 0;
        public ICommand IncreaseCount { get; }
        void IncreaseCountCommand()
        {
            count++;
            CountDisplay = $"text is {count} ";
        }
    }
}
