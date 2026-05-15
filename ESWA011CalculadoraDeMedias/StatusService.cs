using System.Drawing;

namespace ESWA011CalculadoraDeMedias
{
    public class StatusService
    {
        public string DefinirStatusSemestral(double mediaSemestral)
        {
            if (mediaSemestral >= 7.0)
                return "Aprovado";
            else
                return "Em Exame";
        }

        public string DefinirStatusFinal(double mediaFinal)
        {
            if (mediaFinal >= 5.0)
                return "Aprovado";
            else
                return "Reprovado";
        }

        public Color ObterCorStatus(string status)
        {
            if (status == "Aprovado")
                return Color.Green;
            else if (status == "Reprovado")
                return Color.Red;
            else if (status == "Em Exame")
                return Color.Orange;
            else
                return Color.Black;
        }
    }
}