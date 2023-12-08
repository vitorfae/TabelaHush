﻿using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable tabelaHash = new Hashtable();

        while (true)
        {
            Console.Write("Digite o CPF (chave): ");
            string cpf = Console.ReadLine();

            if (string.IsNullOrEmpty(cpf))
            {
                Console.WriteLine("CPF não pode ser vazio. Tente novamente.");
                continue;
            }

            if (tabelaHash.ContainsKey(cpf))
            {
                Console.WriteLine("CPF já existe na tabela. Tente novamente com um CPF diferente.");
                continue;
            }

            Console.Write("Digite o NOME (valor): ");
            string nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não pode ser vazio. Tente novamente.");
                continue;
            }

            try
            {
                tabelaHash.Add(cpf, nome);
                Console.WriteLine("Dados adicionados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao adicionar os dados: " + ex.Message);
            }

            Console.Write("Deseja adicionar mais dados? (S/N): ");
            string resposta = Console.ReadLine();

            if (resposta.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }

        Console.WriteLine("Dados inseridos na tabela Hash:");

        foreach (DictionaryEntry entry in tabelaHash)
        {
            Console.WriteLine($"CPF: {entry.Key}, NOME: {entry.Value}");
        }
    }
}