using eplant.Helpers;
using eplant.Models;
using eplant.Views_Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace eplant.Services
{
    public class FirebaseConnection : IFirebaseConnection
    {

        const string _baseUrl = "https://eplant-947b2.firebaseio.com/";

        NetworkAccess CurrentConnectivity;

        readonly HttpClient Client;

        public FirebaseConnection()
        {
            Client = new HttpClient();
        }

        public async Task<List<RegistroPlanta>> PostRegisterPlantAsync(RegisterPlantModel model)
        {
            try
            {
                CurrentConnectivity = Connectivity.NetworkAccess;
                if (CurrentConnectivity == NetworkAccess.Internet)
                {
                    var modelo = model;
                    var registerPlantUrl = _baseUrl + "RegistroPlanta/.json";
                    var stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                    var response = await Client.PostAsync(registerPlantUrl, stringContent).ConfigureAwait(false);
                    return new List<RegistroPlanta>();
                }
                return new List<RegistroPlanta>();
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogAndSendException(this, nameof(PostRegisterPlantAsync), ex);
                return new List<RegistroPlanta>();
            }
        }
    }
}
