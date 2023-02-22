using AppCentreSampleApplication.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppCentreSampleApplication.Views
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