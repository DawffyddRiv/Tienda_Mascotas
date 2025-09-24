using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tienda_Mascotas.Interfaces;

namespace Tienda_Mascotas.Validadores
{
    public class Validador : IValidarID, IValidarNombre
    {
        public string ValidarID(string identificador)
        {
            if (!Regex.IsMatch(identificador, @"^A-\d{2}$"))
            {
                throw new FormatException("El ID debe seguir el formato A-xx (siendo x dígitos).");
            }
            return identificador;
            
            
        }
        public string ValidarNombre(string nombre)
        {

            if (!Regex.IsMatch(nombre, @"^[A-Z][a-zA-Z]{1,39}$"))
            {
                throw new FormatException("El nombre debe contener sólo caracteres.Vuelve a introducirlo");
            }
            return nombre;             
        }
        public decimal ValidarPrecio(string precio) 
        {
            if (!Regex.IsMatch(precio, @"^\d+(\.\d+)?$")) 
            {
                throw new FormatException("El valor debe ser un número entero o decimal válido.");
            }
            return decimal.Parse(precio);
        }
         
    }
    
    
}
