using SimplerXAMLPlayground.Models;
using SimplerXAMLPlayground.PageModels;

namespace SimplerXAMLPlayground.Pages
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