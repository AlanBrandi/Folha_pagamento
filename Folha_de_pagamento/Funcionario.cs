using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Folha_de_pagamento
{
    class Funcionario
    {
        //Encapsulamento variáveis Nome, HorasTrabalhadas, ValorPorHora e PagamentoTotal.
        public string Nome { get; set; }
        public double HorasTrabalhadas { get; set; }
        public double ValorPorHora { get; set; }
         
        public double PagamentoTotal { get; set; }
        //Construtor personalizado.
        public Funcionario(string nome, double horasTrabalhadas, double valorPorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }
        //Método "Pagamento".
        public void Pagamento()
        {
            //Cálculo do pagamento total.
            PagamentoTotal = ValorPorHora * HorasTrabalhadas;
        }
        //Método ToString.
        public override string ToString()
        {
            //Método ToString(transforma o que se colocar em string), retorna o conteúdo em uma lista para demonstrar.
            return "Nome: " + Nome + "\nPagamento: " + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);    
        }
    }
}
