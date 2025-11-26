using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace INFRA
{
    public static class RegexHelper
    {
        // formato de email
        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            string patron = @"^[\w.-]+@([\w-]+\.)+[\w-]{2,4}$";
            return Regex.IsMatch(email, patron);
        }

        // validacion de numero positivo (entero o decimal)
        public static bool ValidarNumeroPositivo(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor)) return false;
            // el patron permite numeros como "123", "123.45", "123,45"
            string patron = @"^[0-9]+([.,][0-9]+)?$";
            return Regex.IsMatch(valor, patron);
        }

        // valida texto alfanumérico con longitud mínima y máxima
        public static bool ValidarTextoAlfanumerico(string texto, int minLength, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(texto)) return false;
            string patron = $@"^[a-zA-Z0-9\s]{{{minLength},{maxLength}}}$";
            return Regex.IsMatch(texto, patron);
        }

        // valida formato de CUIT (número de identificación fiscal en Argentina)
        public static bool ValidarCUIT(string cuit)
        {
            if (string.IsNullOrWhiteSpace(cuit)) return false;
            string patron = @"^\d{2}-?\d{8}-?\d{1}$";
            return Regex.IsMatch(cuit, patron);
        }

        // valida formato de teléfono
        public static bool ValidarTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono)) return false;
            string patron = @"^[\d\s\-\(\)\+]{7,20}$";
            return Regex.IsMatch(telefono, patron);
        }
    }
}