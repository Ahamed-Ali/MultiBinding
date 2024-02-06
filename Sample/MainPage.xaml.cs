using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        MyViewModel Vm;
      
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = Vm = new MyViewModel();
           
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var vm = this.BindingContext as MyViewModel;
            if (vm!= null)
            {
                vm.Price++;
            }
            
        }

        
    }

    public partial class MyViewModel : ObservableObject
    {
        [ObservableProperty] double _Price = 2;
    }

}
