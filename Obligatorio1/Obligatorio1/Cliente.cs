using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    internal class Cliente
    {
        public string NombreUsuario { get => _nombreUsuario; set
            {
                if (ValidarNombre(value)){
                    _nombreUsuario = value;
                }
                else
                {
                    throw new ArgumentException("El nombre de usuario debe ser unico, case sensitive, alfanumerico, sin espacios y tener entre 3 y 20 caracteres");
                }
            } }
        private string _nombreUsuario;
        public string Contraseña { get => _contraseña; set 
            {
                if (ValidarContraseña(value))
                {
                    _contraseña = value;
                }
                else
                {
                    throw new ArgumentException("La contraseña debe tener al menos una mayuscula, un numero y tener entre 5 y 25 caracteres");
                }
            } }
        private string _contraseña;
        public static DateTime Fecha { get { return DateTime.Now; } }

        public Cliente() { }

        public bool ValidarNombre(string nombre) { 
            if(nombre == null || nombre.Length < 3 || nombre.Length > 20)
            {
                return false;
            }
            if(nombre.Contains (" "))
            {
                return false;
            }
            for(int i=0; i<nombre.Length; i++)
            {
                if (!Char.IsLetterOrDigit(nombre[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidarContraseña(string contraseña) { 
            if(contraseña == null || contraseña.Length < 5 || contraseña.Length > 25)
            {
                return false;
            }
            bool tieneMayuscula = false;
            bool tieneNumero = false;
            foreach(char c in contraseña)
            {
                if (Char.IsUpper(c))
                {
                    tieneMayuscula = true;
                }
                if (Char.IsDigit(c))
                {
                    tieneNumero = true;
                }
            }
            if(!tieneMayuscula || !tieneNumero)
            {
                return false;
            }
            return true;
        }



    }
}
