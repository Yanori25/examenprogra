using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPractico.Capamodelo;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ExamenPractico.Capacontroller
{
    class CalculosController
    {

        public CalculosController() { }


        public Double CalculandoAntiguedad(ModelEmpelado Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion("BDDConexion"))
                {
                    Con.Open();

                    string sql = "execute EventoEmpleados '" + Modelo.NombreEmpleado + "' , '" + Modelo.ApellidoEmpleado +
                        "' ,  " + Modelo.Antiguedad + " , " + Modelo.Salario + " , " + Modelo.RAP +
                        " , " + Modelo.IHSS + " , " + Modelo.ISR + " , " + Modelo.TotalAPagar + " ";

                    //string sql = "insert into Usuarios(IdUsuario,NombreUsuario,)"

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se agrego exitosamente");

                    Con.Close();
                }

                return 200;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Informacion del sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return 0;
            }
        }



    }
}
