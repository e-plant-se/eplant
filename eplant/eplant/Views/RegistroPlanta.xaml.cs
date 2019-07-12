using eplant.Views_Models;
using System.ComponentModel;
using Xamarin.Forms;

namespace eplant
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class RegistroPlanta : ContentPage
    {

        RegistroPlantaViewModel _vm;

        public RegistroPlanta()
        {
            InitializeComponent();
            _vm = new RegistroPlantaViewModel();
            radioButtonCultivo.ItemsSource = _vm.tipoCultivo;
            radioButtonRiego.ItemsSource = _vm.tipoRiego;
        }
    }
}
