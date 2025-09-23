using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascotas.Interfaces
{
    public interface IValidarID
    {
        void ValidarID(string idUnico);
    }
    public interface IValidarNombre 
    {
        void ValidarNombre(string nombre);
    }
    public interface IValidarPrecio 
    {
        float ValidarPrecio(float precio);
    }
    public interface IValidarFecha 
    {
        void ValidarFecha(string fecha);
    }
}
