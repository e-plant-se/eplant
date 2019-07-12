using Xamarin.Forms;

namespace eplant.Views_Models
{
    public class RegistroPlantaViewModel
    {
        public string[] tipoCultivo = { "Plantula", "Por semilla", "Germinado" };
        public string[] tipoRiego = { "Abundante", "Moderado", "Poco" };

        public Command getListCommand { get; set; }

        public RegistroPlantaViewModel()
        {
            //getListCommand = new Command(async () => await getList());
        }
    }
}
