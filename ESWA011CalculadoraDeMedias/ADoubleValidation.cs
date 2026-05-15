using System;

namespace ESWA011CalculadoraDeMedias
{
    public abstract class ADoubleValidation
    {
        protected double LowerLimit { get; set; }
        protected double UpperLimit { get; set; }

        protected ADoubleValidation(double lowerLimit, double upperLimit)
        {
            LowerLimit = lowerLimit;
            UpperLimit = upperLimit;
        }

        public virtual bool DoubleIsValid(double value)
        {
            return value >= LowerLimit && value <= UpperLimit;
        }
    }
}