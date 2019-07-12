using eplant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eplant.Views_Models
{
    public class CamaViewModel
    {
        public List<Cama> Camas { get; set; }

        public CamaViewModel()
        {
            Camas = new Cama().GetCamas();
        }
    }
}
