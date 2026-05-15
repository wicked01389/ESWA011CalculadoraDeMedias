using System.Text.RegularExpressions;

namespace ESWA011CalculadoraDeMedias
{
    public static class Text
    {
        public static string Sanitize(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "0";

            // Remove tudo que não é número, vírgula ou ponto
            string sanitized = Regex.Replace(text, @"[^0-9,.]", "");

            // Substitui vírgula por ponto
            sanitized = sanitized.Replace(',', '.');

            // Se ficou vazio, retorna "0"
            if (string.IsNullOrEmpty(sanitized))
                return "0";

            return sanitized;
        }
    }
}