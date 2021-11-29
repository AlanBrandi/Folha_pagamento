using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Folha_de_pagamento
{
    class Terceirizado : Funcionario
    {
        //Variáveis "DespesaAdicional" e "Bonus" + Encapsulamento.
        public double DespesaAdicional { get; set; }
        public double Bonus { get; set; }
        //Construtor personalizado.
        public Terceirizado(string name, double horasTrabalhadas, double valorPorHora, double despesaAdiconal) : base(name, horasTrabalhadas, valorPorHora)
        {
            DespesaAdicional = despesaAdiconal;
        }
        //Método Pagamento "Bonus".
        public void PagamentoBonus()
        {
            //Cálculo para o Bonus.
           Bonus = (DespesaAdicional * 1.10) - DespesaAdicional;
        }   
        //Método PagamentoTerceirizado.
        public void PagamentoTerceirizado()
        {
            //Cálculo pagamento total.
            PagamentoBonus();
            PagamentoTotal = HorasTrabalhadas * ValorPorHora + Bonus;
        }
        //Método ToString.
        public override string ToString()
        {
            return "Nome: " + Nome + "\nPagamento: " + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
