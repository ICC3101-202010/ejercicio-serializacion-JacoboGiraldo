using System;
using System.Runtime.Serialization;

namespace Ejercicio_S
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public Persona(string N, string A, int E)
        {
            nombre = N;
            apellido = A;
            edad = E;
        }

        public string Show()
        {
            string Info = "";
            Info += "Nombre: " + nombre + "\n";
            Info += "Apellido: " + apellido + "\n";
            Info += "Edad: " + edad + "\n";
            return Info;
        }
    }
}
