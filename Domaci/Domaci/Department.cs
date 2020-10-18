using System;
using System.Collections.Generic;
using System.Text;

namespace Domaci_2
{
    class Department
    {
        public String Title;
        public String Code = "Nema smera!";

        public Department(string Code)
        {
            if (Code.Equals("IT") || Code.Equals("it"))
                Title = "Informacione Tehnologije";
            else if (Code.Equals("RI") || Code.Equals("ri"))
                Title = "Racunarska Tehnika";
            else
                Title = "Nema smera!";
        }
    }
}
