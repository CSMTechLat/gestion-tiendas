using gestionVentas.Models;
using gestionVentas.PageModels;

namespace gestionVentas.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}