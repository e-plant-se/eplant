using eplant.Models;
using eplant.Services;
using System.Threading.Tasks;

namespace eplant.Views_Models
{
    public class RegistroPlantaViewModel
    {
        public string[] tipoCultivo = { "Plantula", "Por semilla", "Germinado" };
        public string[] tipoRiego = { "Abundante", "Moderado", "Poco" };
        public FirebaseConnection WebApi;
        public RegisterPlantModel modelo;

        public RegistroPlantaViewModel()
        {
            WebApi = new FirebaseConnection();
            modelo = new RegisterPlantModel();
        }

        public void WriteRegisterPlantAsync(string nombreComun, string nombreCientifico, string temporada, string tipoRiego, string tipoCultivo, string cicloVida, string uso, string tamaño)
        {
            var model = new RegisterPlantModel()
            {
                NombreComun = nombreComun,
                NombreCientifico = nombreCientifico,
                Temporada = temporada,
                TipoRiego = tipoRiego,
                TipoCultivo = tipoCultivo,
                Uso = uso,
                CicloVida = cicloVida,
                Tamaño = tamaño
            };
            Task.Run(async () => await WebApi.PostRegisterPlantAsync(model));
        }
    }
}
