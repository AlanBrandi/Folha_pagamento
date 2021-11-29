using System;
using System.Collections.Generic;

namespace Folha_de_pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de duas listas, funcionarios e terceirizados.
            List<Funcionario> listF = new List<Funcionario>();
            List<Terceirizado> listT = new List<Terceirizado>();
            //Criação da variável Despesa Adicional.
            double DespesaAdicional;
            
            //Perguntando quantos funcionários serão cadastrados + guardando valor em "n".
            Console.Write("Número de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            //Adicionando e pegando informações de acordo com a quantidade de n.
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #{i}");
                //Perguntando se é Comum ou terceirizado + guardando valor em "Tipo".
                Console.Write("Comum ou Terceirizado (C/T)? ");
                char Tipo = char.Parse(Console.ReadLine());
                //Perguntando o nome + guardando em "Nome"
                Console.Write("Nome: ");
                String Nome = Console.ReadLine();
                //Perguntando horas trabalhadas + guardando em "HorasTrabalhadas".
                Console.WriteLine("Horas trabalhadas: ");
                double HorasTrabalhadas = double.Parse(Console.ReadLine());
                //Perguntando o valor por horas trabalhadas + guardando em "ValorPorHoras".
                Console.WriteLine("Valor por horas: ");
                double ValorPorHoras = double.Parse(Console.ReadLine());
                //Se acaso for comum entre aqui.
                if (Tipo == 'C')
                {
                    //Adiciona na lista de funcionarios um novo.
                    listF.Add(new Funcionario(Nome, HorasTrabalhadas, ValorPorHoras));
                }
                //Caso for terceirizado entre aqui.
                else if (Tipo == 'T')
                {
                    //Pergunta a despesa adicional + guardando em "DespesaAdicional".
                    Console.WriteLine("Despesa adicional: ");
                    DespesaAdicional = double.Parse(Console.ReadLine());
                    //Adiciona na lista de terceirizados.
                    listT.Add(new Terceirizado(Nome, HorasTrabalhadas, ValorPorHoras, DespesaAdicional));
                }
            }
            //Limpa o console
            Console.Clear();
            //Mostra os dados para o usuário.
            Console.WriteLine("Dados: ");
            Console.WriteLine("==========================================");
            Console.WriteLine("Comum: ");
            Console.WriteLine("==========================================");
            //Para cada funcionário que estiver na lista de comum.
            foreach (Funcionario elemento in listF)
            {
                //Execute o método "Pagamento" + mostra no console usando o método "ToString".
                elemento.Pagamento();
                Console.WriteLine(elemento.ToString());
            }
            //Mostra agora os dados de quem é terceirizado.
            Console.WriteLine("==========================================");
            Console.WriteLine("Terceirizado: ");
            Console.WriteLine("==========================================");
            //Para cada terceirizado na lista de terceirizados.
            foreach (Terceirizado elemento in listT)
            {
                //Executa o método pagamentoTerceirizado + mostra no console usando o método "ToString".
                elemento.PagamentoTerceirizado();
                Console.WriteLine(elemento.ToString());
            }
        }
    }
}
