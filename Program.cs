using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CPF cpf = new CPF();

            cpf.nome = "Gustavo";
            System.Console.WriteLine( cpf.Saudar() );

            cpf.cpf = "000.000.000-00";
            System.Console.WriteLine( cpf.vailidarCPF() );

            System.Console.WriteLine("---------------------------------------------------------");
            CNPJ cnpj = new CNPJ();

            cnpj.nome = "Gustavo";
            System.Console.WriteLine( cnpj.Saudar() );

            cnpj.cnpj = "00.000.000/0000-00";
            System.Console.WriteLine( cnpj.ValidarCNPJ() );
        }
    }
}
