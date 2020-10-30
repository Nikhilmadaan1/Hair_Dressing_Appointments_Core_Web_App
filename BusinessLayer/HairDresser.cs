using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hair_Dressing_Appointments_Core_Web_App.BusinessLayer
{
    //Hair dresser details
    public class HairDresser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsPermanent { get; set; }
    }
}
