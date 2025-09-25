using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascotas.Interfaces
{
    public interface IValidarID
    {
        string ValidarID(string idUnico);
    }
    public interface IValidarNombre 
    {
        string ValidarNombre(string nombre);
    }
    public interface IValidarPrecio 
    {
        decimal ValidarPrecio(string precio);
    }
    public interface IValidarFecha 
    {
        DateTime ValidarFecha(string fecha);
    }
}
