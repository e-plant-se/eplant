using eplant.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace eplant.Services
{
    public interface IFirebaseConnection
    {
        Task<List<RegistroPlanta>> PostRegisterPlantAsync(RegisterPlantModel model);
        Task saveImage(Stream imgSteram, string nameImage);
    }
}
