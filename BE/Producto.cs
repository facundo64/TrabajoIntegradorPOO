using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public int ProveedorId { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}