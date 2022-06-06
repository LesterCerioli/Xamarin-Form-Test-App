using System.ComponentModel;
using Test.XamarinForms.ViewModels;
using Xamarin.Forms;

namespace Test.XamarinForms.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}