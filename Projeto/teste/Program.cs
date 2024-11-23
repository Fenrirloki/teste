namespace teste;
using System;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cpf { get; set; }

    // Construtor da classe
    public Aluno(string nome, int idade, string cpf)
    {
        Nome = nome;
        Idade = idade;
        Cpf = cpf;
    }

    // Método para exibir as informações de um aluno
    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}, CPF: {Cpf}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>(); // Lista dinâmica para armazenar alunos
        string continuarCadastro;

        do
        {
            // Recebe os dados do aluno
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade do aluno: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o CPF do aluno: ");
            string cpf = Console.ReadLine();

            // Cria um novo objeto Aluno e adiciona à lista
            Aluno aluno = new Aluno(nome, idade, cpf);
            alunos.Add(aluno);

            // Pergunta se deseja cadastrar outro aluno
            Console.Write("Deseja cadastrar outro aluno? (S/N): ");
            continuarCadastro = Console.ReadLine().ToUpper();

        } while (continuarCadastro == "S");

        // Exibe a lista de alunos cadastrados
        Console.WriteLine("\nLista de alunos cadastrados:");
        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine(aluno);
            
            if(aluno.Nome.Equals("Pedro")){
                Console.WriteLine($"{aluno.Nome} vc é top");
            }
            string nome = aluno.Nome;
            int idade = aluno.Idade;
            string cpf = aluno.Cpf;
        }
    }
}
