using BE;
using BLL.Interfaces;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class CategoriaService : ICrud<Categoria>
    {
        private EFContext db = new EFContext();

        public List<Categoria> Listar()
        {
            return db.Categorias.ToList();
        }

        public bool Agregar(Categoria obj)
        {
            db.Categorias.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Modificar(Categoria obj)
        {
            var temp = db.Categorias.Find(obj.Id);
            temp.Descripcion = obj.Descripcion;
            temp.Activa = obj.Activa;
            return db.SaveChanges() > 0;
        }

        public bool Borrar(int id)
        {
            var temp = db.Categorias.Find(id);
            db.Categorias.Remove(temp);
            return db.SaveChanges() > 0;
        }

        public Categoria Obtener(int id) { return db.Categorias.Find(id); }
    }
}