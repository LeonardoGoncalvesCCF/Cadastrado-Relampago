using System;

namespace CadastroRelampago
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------------");


            //Solicitando Nome do Usuário
            Console.Write("Digite seu nome: ");
            string? nome = Console.ReadLine();

            Console.WriteLine("-------------------------");

            //Solicitando Idade do Usuário
            Console.Write("Digite sua idade: ");
            string? idade = Console.ReadLine();
            int idadeInt = Convert.ToInt32(idade);

            Console.WriteLine("-------------------------");

            //Solicitando Sexo do Usuário
            Console.Write("Digite seu sexo (M | F): ");
            string? sexo = Console.ReadLine();

            char sexoChar;

            if (sexo != null || sexo != "")
            {
            }


            Console.WriteLine("-------------------------");

            //Solicitando Endereço do Usuário
            Console.Write("Digite seu endereço: ");
            string? endereco = Console.ReadLine();

            Console.WriteLine("-------------------------");

            Console.WriteLine("\n --- Informações do Usuário ---");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade); //string
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Endereço: " + endereco);
            Console.WriteLine("Idade: " + (idadeInt + 2)); //int
            Console.WriteLine("-------------------------");

        }
    }


}