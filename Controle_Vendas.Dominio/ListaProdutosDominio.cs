﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Vendas.Dominio
{
    public class ListaProdutosDominio
    {
        private int codigoProduto;
        private string nomeProduto;
        private string embalagem;
        private string tamanho;
        private string sabor;
        private int quantidadeEstoqueInicial;
        private decimal precoDeLista;

        public int CodigoProduto { get => codigoProduto; set => codigoProduto = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public string Embalagem { get => embalagem; set => embalagem = value; }
        public string Tamanho { get => tamanho; set => tamanho = value; }
        public string Sabor { get => sabor; set => sabor = value; }
        public int QuantidadeEstoqueInicial { get => quantidadeEstoqueInicial; set => quantidadeEstoqueInicial = value; }
        public decimal PrecoDeLista { get => precoDeLista; set => precoDeLista = value; }
    }
}
