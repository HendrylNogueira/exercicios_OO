namespace exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno_x = new();

            Console.Write("Nome do aluno: ");
            aluno_x.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            
            aluno_x.Nota1 = double.Parse(Console.ReadLine());
            aluno_x.Nota2 = double.Parse(Console.ReadLine());
            aluno_x.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL = {aluno_x.NotaFinal():F2}");

            if (aluno_x.NotaFinal() >= 60)
            {
                aluno_x.Aprovado();
            }
            else
            {
                aluno_x.Reprovado();
            }
        }
    }
}