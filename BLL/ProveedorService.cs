using BE;
using BLL.Interfaces;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ProveedorService : ICrud<Proveedor>
    {
        private EFContext db = new EFContext();

        public List<Proveedor> Listar()
        {
            return db.Proveedores.ToList();
        }
        // Para este paso rápido solo pongo el listar, que es lo urgente para el combo
        // Deberías completar Agregar/Modificar/Borrar igual que en CategoriaService
        public bool Agregar(Proveedor obj) { return false; }
        public bool Modificar(Proveedor obj) { return false; }
        public bool Borrar(int id) { return false; }
        public Proveedor Obtener(int id) { return null; }
    }
}