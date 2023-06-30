using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenPractico.Capacontroller;
using ExamenPractico.Capamodelo;


namespace ExamenPractico
{

    public partial class Form1 : Form
    {


        empleadoController emple = new empleadoController();
        ModelEmpelado model = new ModelEmpelado();


        public Form1()
        {
           InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void refrescar()
        {
            dgvempleados.DataSource = emple.getempleados();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.refrescar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            model.NombreEmpleado = txtempleado.Text;
            model.ApellidoEmpleado = txtapellido.Text;
            model.Antiguedad = 0;
            model.Salario = Convert.ToDouble(txtsalario.Text);
            model.RAP = 0;
            model.IHSS = 0;
            model.ISR = 0;
            model.TotalAPagar = 0; 
            emple.CrearEmpleado(model);
            this.refrescar();
        }
    }
}
