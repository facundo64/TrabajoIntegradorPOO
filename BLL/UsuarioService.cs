using BE;
using DAL.DAOs;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class UsuarioService
    {
        private UsuarioDAO usuarioDAO;

        public UsuarioService()
        {
            usuarioDAO = new UsuarioDAO();
        }

        public Usuario ValidarUsuario(string nombreUsuario, string password)
        {
            Usuario usuarioEncontrado = usuarioDAO.ObtenerPorUsername(nombreUsuario);

            if (usuarioEncontrado == null) return null;

            byte[] passwordIngresado = EncriptarPassword(password);

            if (SonIguales(usuarioEncontrado.PasswordHash, passwordIngresado))
            {
                return usuarioEncontrado;
            }

            return null;
        }

        private byte[] EncriptarPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.Unicode.GetBytes(password));
            }
        }

        private bool SonIguales(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
    }
}