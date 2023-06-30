using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico.Capamodelo
{
   public  class ModelEmpelado
    {
        public int CodigoEmpleado { get; set; }

        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }

        public DateTime FechaIngreso { get; set; }

       
        public int Antiguedad { get; set; }

        public Double Salario { get; set; }
        public Double RAP { get; set; }

        public Double IHSS { get; set; }

        public Double ISR { get; set; }

        public Double TotalAPagar { get; set; }



        public static DataTable ListarEmpleados { get; set; }

        public ModelEmpelado () { }
    }
}
