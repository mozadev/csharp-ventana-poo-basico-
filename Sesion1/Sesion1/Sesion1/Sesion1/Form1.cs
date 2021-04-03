using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sistemas;
using Capacitacion;

namespace Sesion1
{
    public partial class Form1 : Form
    {
        //Objetos
        Alumno obja = new Alumno();
        Curso objcur = new Curso();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            obja.Nombre = txtNombre.Text;//Lectura(set)
            obja.Edad =Convert.ToInt16(txtEdad.Text);
            obja.Apellido = txtApellido.Text;

            MessageBox.Show(obja.Nombre);//Escritura(get)
        }
    }
}
