using ESWA011CalculadoraDeMedias;
using System;

namespace ESWA011CalculadoraDeMedias
{
    public class NotaValidator : ADoubleValidation
    {
        public NotaValidator() : base(0.0, 10.0)
        {
        }

        public override bool DoubleIsValid(double value)
        {
            double rounded = Math.Round(value, 1, MidpointRounding.AwayFromZero);
            return rounded >= LowerLimit && rounded <= UpperLimit;
        }
    }
}