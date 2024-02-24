
namespace exercicio06
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3);
        }

        public void Aprovado()
        {
            Console.WriteLine("APROVADO");
        }

        public void Reprovado()
        {
            double nota_faltante = 60 - NotaFinal();
            Console.WriteLine($"REPROVADO \n" +
                $"FALTARAM {nota_faltante:F2} PONTOS");
        }

    }
}
