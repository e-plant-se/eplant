using eplant.Models;
using eplant.Services;
using System.IO;
using System.Threading.Tasks;

namespace eplant.Views_Models
{
    public class RegistroPlantaViewModel
    {

        #region Properties and variables

        public string[] tipoCultivo = { "Plantula", "Por semilla", "Germinado" };
        public string[] tipoRiego = { "Abundante", "Moderado", "Poco" };
        public FirebaseConnection WebApi;
        public RegisterPlantModel modelo;

        #endregion

        public RegistroPlantaViewModel()
        {
            WebApi = new FirebaseConnection();
            modelo = new RegisterPlantModel();
        }

        #region Methods

        public async void WriteRegisterPlantAsync(Stream streamFile,string stream, string nombreComun, string nombreCientifico, string temporada, string tipoRiego, string tipoCultivo, string cicloVida, string uso, string tamaño)
        {
            var model = new RegisterPlantModel()
            {
                Imagen = stream,
                NombreComun = nombreComun,
                NombreCientifico = nombreCientifico,
                Temporada = temporada,
                TipoRiego = tipoRiego,
                TipoCultivo = tipoCultivo,
                Uso = uso,
                CicloVida = cicloVida,
                Tamaño = tamaño
            };
            await WebApi.saveImage(streamFile, stream);
            await WebApi.PostRegisterPlantAsync(model);
        }

        #endregion

    }
}
