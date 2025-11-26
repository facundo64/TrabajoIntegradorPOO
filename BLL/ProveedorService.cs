using BE;
using BLL.Interfaces;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ProveedorService : ICrud<Proveedor>
    {
       

        public List<Proveedor> Listar()
        {
           
            using (var db = new EFContext())
            {
                return db.Proveedores.ToList();
            }
        }

        public bool Agregar(Proveedor obj)
        {
        
            using (var db = new EFContext())
            {
                try
                {
                    db.Proveedores.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    
                    throw; 
                }
            }
        }

        public bool Modificar(Proveedor obj)
        {
            using (var db = new EFContext())
            {
                try
                {
                    var original = db.Proveedores.Find(obj.Id);
                    if (original != null)
                    {
                        original.RazonSocial = obj.RazonSocial;
                        original.CUIT = obj.CUIT;
                        original.Email = obj.Email;
                        original.Telefono = obj.Telefono;

                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
                catch (Exception) { throw; }
            }
        }

        public bool Borrar(int id)
        {
            using (var db = new EFContext())
            {
                try
                {
                    var original = db.Proveedores.Find(id);
                    if (original != null)
                    {
                        db.Proveedores.Remove(original);
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
                catch (Exception) { throw; }
            }
        }

        public Proveedor Obtener(int id)
        {
            using (var db = new EFContext())
            {
                return db.Proveedores.Find(id);
            }
        }
    }
}