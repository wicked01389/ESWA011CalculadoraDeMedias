using ESWA011CalculadoraDeMedias;
using System;

namespace ESWA011CalculadoraDeMedias
{
    public class MediaCalculator
    {
        private const double PESO_NP1 = 0.4;
        private const double PESO_NP2 = 0.4;
        private const double PESO_PIM = 0.2;

        public double CalcularMediaSemestral(double np1, double np2, double pim)
        {
            var validator = new NotaValidator();

            if (!validator.DoubleIsValid(np1) ||
                !validator.DoubleIsValid(np2) ||
                !validator.DoubleIsValid(pim))
            {
                throw new ArgumentException("Todas as notas devem estar entre 0 e 10");
            }

            double media = (PESO_NP1 * np1) + (PESO_NP2 * np2) + (PESO_PIM * pim);
            return Arredondar(media);
        }

        public double CalcularMediaFinal(double mediaSemestral, double exame)
        {
            var validator = new NotaValidator();

            if (!validator.DoubleIsValid(mediaSemestral) ||
                !validator.DoubleIsValid(exame))
            {
                throw new ArgumentException("Média semestral e exame devem estar entre 0 e 10");
            }

            double media = (mediaSemestral + exame) / 2.0;
            return Arredondar(media);
        }

        public double Arredondar(double valor)
        {
            return Math.Round(valor, 1, MidpointRounding.AwayFromZero);
        }
    }
}