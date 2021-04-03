using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas
{
    public class Alumno
    {
        //Atributos de instancia
        private String nombre;
        private String apellido;
        //private int edad;
        public int Edad { get; set; }

        //Metodos especiales: propiedades
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        //Metodos(requerimientos)
        public void Matricularse()
        {
        }

        public void Retirarsecurso()
        {
        }

        public String Saludar(String mensaje)
        {
            return mensaje;
        }
    }
}
