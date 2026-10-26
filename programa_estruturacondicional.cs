using System;
					
public class Program
{
	public static void Main()
	{
		//declaração de variaveis
		string nome;
		string sobrenome;
		int idade;
		
		
		//coleta de variáveis
		Console.WriteLine("Insira o Nome");
		nome = Console.ReadLine();
		Console.WriteLine("Insira seu Sobrenome");
		sobrenome = Console.ReadLine();
		Console.WriteLine("Insira a Idade");
		idade = Convert.ToInt16(Console.ReadLine());
		
		//Exibição e Tratamento de Dados
		Console.WriteLine("Olá " + nome + " " + sobrenome);
		Console.WriteLine("Sua Idade é: " + idade);
		if (idade >=18){
			Console.WriteLine("Você é maior de idade");	
	}
		else {
			Console.WriteLine("Você é menor de idade");
		}
		
	}
}