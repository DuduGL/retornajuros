using RetornaJuros.Services.Interfaces;

namespace RetornaJuros.Services.Implementations
{
    public class RetornaJurosService : IRetornaJurosService
    {
        public decimal RetornaJuros()
        {
            return juros / 100;
        }

        private decimal juros => 1;
    }
}
