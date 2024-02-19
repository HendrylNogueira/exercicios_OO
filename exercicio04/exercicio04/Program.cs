namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            
            Console.WriteLine("Digite a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area: {retangulo.Area():F2}");
            Console.WriteLine($"Perimetro: {retangulo.Perimetro():F2}");
            Console.WriteLine($"Diagonal: {retangulo.Diagonal():F2}");

            Console.Read();
        }
    }
}