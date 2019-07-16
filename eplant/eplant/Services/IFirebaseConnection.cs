using eplant.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eplant.Services
{
    interface IFirebaseConnection
    {
        Task<List<RegistroPlanta>> PostRegisterPlantAsync(RegisterPlantModel model);
    }
}
