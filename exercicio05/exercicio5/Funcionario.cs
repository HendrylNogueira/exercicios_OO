﻿
namespace exercicio5
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        
        

        public double SalarioLiquido()
        {
            
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (porcentagem / 100) * (SalarioBruto);
        }

        public override string ToString()
        {
            return $"Funcionario: {Nome}, R${SalarioLiquido():F2}";
        }
    }
}
