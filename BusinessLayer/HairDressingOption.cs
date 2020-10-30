using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hair_Dressing_Appointments_Core_Web_App.BusinessLayer
{
    //Hair dressing options
    public class HairDressingOption
    {
        public int Id { get; set; }

        public string OptionName { get; set; }

        public decimal Charge { get; set; }

    }
}
