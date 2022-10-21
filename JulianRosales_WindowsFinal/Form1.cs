using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace JulianRosales_WindowsFinal
{
    public partial class Form1 : Form
    {

        string nombre;
        string apellido;
        double sueldo;
        string puesto;
        double[] horas = new double[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidaciones_Click(object sender, EventArgs e)
        {
            guardarDatos();

            Boolean st = true;

            if (sueldo <= 0)
            {
                st = false;
            }
            else if (puesto != "SOPORTE TECNICO" && puesto != "DBA" && puesto != "DESARROLLADOR")
            {
                st = false;
            }

            if (st == false)
            {
                MessageBox.Show("No cumple las validaciones solicitadas. \nEl sueldo debe ser mayor a 0 y el puesto debe ser de Soporte Tecnico, DBA o Desarrollador");
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            guardarDatos();
            MessageBox.Show(nombre.ToUpper() + " " + apellido.ToUpper() + "\n" + puesto);
        }
        private void btnHoras_Click(object sender, EventArgs e)
        {
            string[] dias = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
            double aux, total = 0;
            for (int i = 0; i < 5; i++)
            {
                aux = Convert.ToDouble(Interaction.InputBox("Ingreses cuantas horas trabajo el dia " + dias[i] + ":"));
                horas[i] = aux;
                total += aux;
            }

            MessageBox.Show("Usted trabajo un total de " + total + " horas esta semana.");
        }

        #region
        private void guardarDatos()
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            sueldo = Convert.ToDouble(txtSueldo.Text);
            puesto = txtPuesto.Text.ToUpper();

        }

        #endregion

        
    }
}
