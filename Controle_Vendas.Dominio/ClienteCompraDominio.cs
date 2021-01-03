﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Vendas.Dominio
{
    public class ClienteCompraDominio
    {
        private int codigoCompra;
        private int codigoVenda;
        private int codigoCliente;
        private int codigoProduto;
        private string nomeProduto;
        private int quantidade;
        private double creditoLoja;
        private double preco;
        private double precoTotal;
        private string dataHora;

        public int CodigoCompra { get => codigoCompra; set => codigoCompra = value; }
        public int CodigoVenda { get => codigoVenda; set => codigoVenda = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public int CodigoProduto { get => codigoProduto; set => codigoProduto = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double CreditoLoja { get => creditoLoja; set => creditoLoja = value; }
        public double Preco { get => preco; set => preco = value; }
        public double PrecoTotal { get => precoTotal; set => precoTotal = value; }
        public string DataHora { get => dataHora; set => dataHora = value; }
    }
}