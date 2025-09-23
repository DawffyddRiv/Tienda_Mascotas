using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tienda_Mascotas.Interfaces;

namespace Tienda_Mascotas.Validadores
{
    public class ValidadorIDAnimal : IValidarID
    {
        public void ValidarID(string identificador) 
        { 
            if(!Regex.IsMatch(identificador, @"^A-\d{2}$")) 
            {
                throw new Exception("El ID para animales debe seguir el siguiente formato A-xx siendo x digitos ");
            }

        }
    }
}
