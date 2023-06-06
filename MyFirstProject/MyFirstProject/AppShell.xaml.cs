using System;
using Xamarin.Forms;
using Microsoft.Research.SEAL;

namespace MyFirstProject
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        

        public AppShell()
        {
            InitializeComponent();

        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }


}
