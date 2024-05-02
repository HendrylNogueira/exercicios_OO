namespace exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar: ");
            ConversorDeMoeda.Dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.QuantDolar = double.Parse(Console.ReadLine());


            Console.WriteLine($"Valor IOF = {ConversorDeMoeda.IOF():F2}");
            Console.WriteLine($"Valor total a ser pago em reais = {ConversorDeMoeda.Total():F2}");

        }
    }
}