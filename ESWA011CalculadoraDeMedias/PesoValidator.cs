using ESWA011CalculadoraDeMedias;

namespace ESWA011CalculadoraDeMedias
{
    public class PesoValidator : ADoubleValidation
    {
        public PesoValidator() : base(0.0, 1.0)
        {
        }
    }
}