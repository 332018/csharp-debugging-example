using System;
using System.Collections.Generic;
using System.Text;

namespace Domaci_2
{
    class Department
    {
        public String Title;
        public String Code;

        public Department()
        {
            if (Code == "IT")
                Title = "Informacione Tehnologije";
            else if (Code == "RI")
                Title = "Racunarska Tehnika";
            else
                Title = "Nista od navedenog";
        }
    }
}
