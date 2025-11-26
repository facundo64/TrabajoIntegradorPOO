using BE;
using BLL.Interfaces;
using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ProductoService : ICrud<Producto>
    {
        private EFContext db;

        public ProductoService()
        {
            db = new EFContext();
        }

        public List<Producto> Listar()
        {
            return db.Productos
                     .Include(p => p.Categoria)
                     .Include(p => p.Proveedor)
                     .ToList();
        }

        public bool Agregar(Producto obj)
        {
            try
            {
                db.Productos.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Modificar(Producto obj)
        {
            try
            {
                var original = db.Productos.Find(obj.Id);
                if (original != null)
                {
                    original.Nombre = obj.Nombre;
                    original.Precio = obj.Precio;
                    original.Stock = obj.Stock;
                    original.CategoriaId = obj.CategoriaId;
                    original.ProveedorId = obj.ProveedorId;
                    original.Activo = obj.Activo;

                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Borrar(int id)
        {
            try
            {
                var obj = db.Productos.Find(id);
                if (obj != null)
                {
                    db.Productos.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Producto Obtener(int id)
        {
            return db.Productos.Find(id);
        }
    }
}