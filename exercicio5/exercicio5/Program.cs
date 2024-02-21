namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario pessoa = new Funcionario();
            double porcento;

            Console.Write("Digite seu nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Digite o Salário Bruto: ");
            pessoa.SalarioBruto = int.Parse(Console.ReadLine());

            Console.Write("Digite o imposto: ");
            pessoa.Imposto = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(pessoa);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            porcento = double.Parse(Console.ReadLine());

            pessoa.AumentarSalario(porcento);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + pessoa);

            Console.ReadLine();
        }
    }
}