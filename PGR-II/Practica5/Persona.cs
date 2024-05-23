using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_05_23_24
{
    internal class Persona
    {

      // : significa que esta heredando
        #region Propiedades y atributos

        private string nombres;
        private string apellidos;
        private string ci;
        private char sexo;
        private DateTime fechanacimiento;

        public DateTime Fechanacimiento
        {
            get { return fechanacimiento; }
            set { fechanacimiento = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
			get { return nombres; }
			set { nombres = value; }
		}
        #endregion

        #region Constructores
        public Persona(string nombres, string apellidos, string ci, char sexo, DateTime fechanacimiento)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Ci = ci;
            Sexo = sexo;
            Fechanacimiento = fechanacimiento;
        }
      //Recuerda
      //this. -->parametro de la clase
        public Persona()
        {

        }
        
        #endregion

        #region Metodos
          //en las funciones, RECUERDA SIEMPRE CON LAS PROPIEDADES
        public string info()
        {
            return $"{Nombres}-{Apellidos}-{Ci}-{Sexo}-{Fechanacimiento.ToShortDateString}";
        }

        public int calcularEdad()
        {
            return DateTime.Now.Year-Fechanacimiento.Year;
        }
        #endregion
    }
}
