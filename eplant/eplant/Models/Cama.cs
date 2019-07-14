using System;
using System.Collections.Generic;
using System.Text;

namespace eplant.Models
{
    public class Cama
    {
        public string huerto { get; set; }
        public int idCama { get; set; }
        public string tipo { get; set; }
        public string estructura { get; set; }
        public string planta1 { get; set; }
        public string planta2 { get; set; }
        public string imageUrl { get; set; }
        public string fechaCultivo { get; set; }

        public List<Cama> GetCamas()
        {
            List<Cama> camas = new List<Cama>()
            {
                new Cama(){ huerto="Cocoteros", idCama=1, tipo="Dedicado", estructura="Simple", planta1="Jitomates", planta2="", imageUrl="camaVacia.png", fechaCultivo="02-07-2019"},
                new Cama(){ huerto="Cocoteros", idCama=2, tipo="Dedicado", estructura="Simple", planta1="Chile", planta2="", imageUrl="camaVacia.png", fechaCultivo="02-07-2019"},
                new Cama(){ huerto="Cocoteros", idCama=3, tipo="Dedicado", estructura="Simple", planta1="Berenjena", planta2="", imageUrl="camaVacia.png", fechaCultivo="02-07-2019"},
                new Cama(){ huerto="Cocoteros", idCama=4, tipo="Dedicado", estructura="Simple", planta1="Papa", planta2="", imageUrl="camaVacia.png", fechaCultivo="02-07-2019"}
            };
            return camas;
        }
    }
}
