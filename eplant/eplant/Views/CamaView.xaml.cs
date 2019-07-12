using eplant.Views_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eplant.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CamaView : ContentPage
    {
        CamaViewModel vm;
        public CamaView()
        {
            InitializeComponent();
            vm = new CamaViewModel();
            listaCamas = ItemsSource = vm.Camas;
        }
    }
}