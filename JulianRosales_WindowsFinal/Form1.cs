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
        string[] dias = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
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
            //Se utilizan if separados para poder mostrar un mensaje por cada error

            if (sueldo <= 0)
            {
                st = false;
                MessageBox.Show("El sueldo debe ser mayor a 0");
            }
            if (puesto != "SOPORTE TECNICO" && puesto != "DBA" && puesto != "DESARROLLADOR")
            {
                st = false;
                MessageBox.Show("El puesto debe ser de Soporte Tecnico, DBA o Desarrollador");
            }
            if (nombre.Length > 2 && nombre.Length < 50) 
            {
                st = false;
                MessageBox.Show("El nombre debe tener mas de 2 caracteres y menos de 50");
            }
            if (apellido.Length > 2 && apellido.Length < 50) 
            {
                st = false;
                MessageBox.Show("El apellido debe tener mas de 2 caracteres y menos de 50");
            }

            if (st == false)
            {
                MessageBox.Show("No cumple las validaciones solicitadas. Corrija los datos ingresados");
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            guardarDatos();
            MessageBox.Show(nombre.ToUpper() + " " + apellido.ToUpper() + "\n" + puesto);
        }
        private void btnHoras_Click(object sender, EventArgs e)
        {
            double total = recibirHoras();
            double prom = total / 5;


            MessageBox.Show("Usted trabajo un total de " + total + " horas esta semana.\nUn promedio de " + prom + " horas por dia.");
            diaDeMenosHoras();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtSueldo.Clear();
            txtPuesto.Clear();
        }

        #region
        private void guardarDatos()
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            sueldo = Convert.ToDouble(txtSueldo.Text);
            puesto = txtPuesto.Text.ToUpper();

        }

        private double recibirHoras()
        {
            
            double aux, total = 0;
            for (int i = 0; i < 5; i++)
            {
                aux = Convert.ToDouble(Interaction.InputBox("Ingreses cuantas horas trabajo el dia " + dias[i] + ":"));
                horas[i] = aux;
                total += aux;
            }

            return total;
        }

        private void diaDeMenosHoras()
        {
            string mensaje = "";
            for (int i = 0; i < horas.Length; i++)
            {
                if (horas[i] < 4)
                {
                    mensaje += " " + dias[i];
                }
            }

            if (mensaje != "")
            {
                mensaje = "Usted trabajo menos de 4 horas el/los dia/s:" + mensaje;
            }

            MessageBox.Show(mensaje);
        }


        #endregion

    }
}
