using eplant.Models.Interface;
using eplant.Views_Models;
using System.ComponentModel;
using System.Threading.Tasks;
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

        private async Task<bool> Validations()
        {
            if (string.IsNullOrEmpty(entryNombreComun.Text))
            {
                await DisplayAlert("Heey", "Por favor llena el campo nombre común", "Ok");
                return false;
            }
            else if (string.IsNullOrEmpty(entryNombreCientifico.Text))
            {
                await DisplayAlert("Heey", "Por favor llena el campo nombre científico", "Ok");
                return false;
            }
            else if (string.IsNullOrEmpty(entryTemporada.Text))
            {
                await DisplayAlert("Heey", "Por favor llena el campo temporada", "Ok");
                return false;
            }
            else if (string.IsNullOrEmpty(radioButtonRiego.SelectedIndex.ToString()))
            {
                await DisplayAlert("Heey", "Por favor seleccione una opción de riego", "Ok");
                return false;
            }
            else if (string.IsNullOrEmpty(radioButtonCultivo.SelectedIndex.ToString()))
            {
                await DisplayAlert("Heey", "Por favor seleccione una opción de cultivo", "Ok");
                return false;
            }
            else if (string.IsNullOrEmpty(entryCicloVida.Text))
            {
                await DisplayAlert("Heey", "Por favor llena el campo ciclo de vida", "Ok");
                return false;
            }
            else if (string.IsNullOrEmpty(editorUsos.Text))
            {
                await DisplayAlert("Heey", "Por favor llena el campo usos", "Ok");
                return false;
            }
            else if (string.IsNullOrEmpty(entryTamaño.Text))
            {
                await DisplayAlert("Heey", "Por favor llena el campo tamaño", "Ok");
                return false;
            }
            return true;
        }

        async void saveRegistroPlanta(object sender, System.EventArgs e)
        {
            if(await Validations())
            {
                var message = "Datos Guardados";
                DependencyService.Get<IMessage>().LongAlert(message);
                _vm.WriteRegisterPlantAsync(entryNombreComun.Text, entryNombreCientifico.Text, entryTemporada.Text, radioButtonRiego.SelectedIndex.ToString(), radioButtonCultivo.SelectedIndex.ToString(), editorUsos.Text, entryCicloVida.Text, entryTamaño.Text);
                entryNombreComun.Text = null;
                entryNombreCientifico.Text = null;
                entryTemporada.Text = null;
                editorUsos.Text = null;
                entryCicloVida.Text = null;
                entryTamaño.Text = null;
            }
        }
    }
}
