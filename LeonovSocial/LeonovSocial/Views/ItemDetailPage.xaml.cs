using LeonovSocial.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LeonovSocial.Views
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