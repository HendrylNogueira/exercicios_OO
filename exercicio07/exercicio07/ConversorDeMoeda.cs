
namespace exercicio07
{
    internal class ConversorDeMoeda
    {
        public static double Dolar;
        public static double QuantDolar;

        public static double IOF()
        {
            return (Dolar * QuantDolar) * 6 / 100;
        }
        public static double Total()
        {
            return (Dolar * QuantDolar) + IOF();
        }
    }
}
