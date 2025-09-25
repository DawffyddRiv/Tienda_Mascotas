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

        public DateTime ValidarFecha(string fecha) 
        {
            if (!Regex.IsMatch(fecha, @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$")) 
            {
                throw new FormatException("La fecha debe tener el formato dd/mm/aaaa.");
            }
            // Ahora intentamos parsear de verdad (para evitar 31/02/2023, que pasaría la regex)
            if (!DateTime.TryParseExact(fecha, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaValida)) 
            {
                throw new FormatException("La fecha no es válida en el calendario.");
            }
            return fechaValida;
        }
    }
    
    
}
