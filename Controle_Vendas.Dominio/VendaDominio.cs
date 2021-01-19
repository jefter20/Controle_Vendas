﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Vendas.Dominio
{
    public class VendaDominio
    {
        private int codigoVenda;
        private int codigoCliente;
        private string cpf;
        private int codigoProduto;
        private string embalagem;
        private int codigoVendedor;
        private double creditoLoja;
        private string nomeCliente;
        private string nomeProduto;
        private string tamanho;
        private string nomeVendedor;
        private string dataHora;
        private double primeiraCompra;
        private int quantidade;
        private string sabor;
        private double preco;
        private double precoTotal;

        public int CodigoVenda { get => codigoVenda; set => codigoVenda = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int CodigoProduto { get => codigoProduto; set => codigoProduto = value; }
        public string Embalagem { get => embalagem; set => embalagem = value; }
        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        public double CreditoLoja { get => creditoLoja; set => creditoLoja = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public string Tamanho { get => tamanho; set => tamanho = value; }
        public string NomeVendedor { get => nomeVendedor; set => nomeVendedor = value; }
        public string DataHora { get => dataHora; set => dataHora = value; }
        public double PrimeiraCompra { get => primeiraCompra; set => primeiraCompra = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Sabor { get => sabor; set => sabor = value; }
        public double Preco { get => preco; set => preco = value; }
        public double PrecoTotal { get => precoTotal; set => precoTotal = value; }
    }
}
