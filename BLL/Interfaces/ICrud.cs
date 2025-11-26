using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICrud<T>
    {
        List<T> Listar();
        bool Agregar(T obj);
        bool Modificar(T obj);
        bool Borrar(int id);
        T Obtener(int id);
    }
}