﻿using Controle_Vendas.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Vendas.Dominio;


namespace Controle_Vendas.Negocios
{
    public class VendaNegocios
    {
        public List<VendaDominio> Buscar(VendaDominio objVenda)
        {
            return new VendaDados().Buscar(objVenda);
        }

        public List<ClienteDominio> BuscaCliente(ClienteDominio objCliente)
        {
            return new VendaDados().BuscaCliente(objCliente);
        }

        public List<ProdutoDominio> BuscaProduto(ProdutoDominio objProduto)
        {
            return new VendaDados().BuscaProduto(objProduto);
        }

        public List<VendedorDominio> BuscaVendedor(VendedorDominio objVendedor)
        {
            return new VendaDados().BuscaVendedor(objVendedor);
        }

        public List<ClienteCompraDominio> BuscaClienteCompra(ClienteCompraDominio objCompra)
        {
            return new VendaDados().BuscaClienteCompra(objCompra);

        }

        public List<ProdutoEstoqueDominio> BuscaProdutoEstoque(ProdutoEstoqueDominio objEstoque)
        {
            return new VendaDados().BuscaProdutoEstoque(objEstoque);
        }

        public static int Inserir(VendaDominio objVenda)
        {
            return new VendaDados().Inserir(objVenda);
        }

        public static int Editar(VendaDominio objVenda)
        {
            return new VendaDados().Editar(objVenda);
        }

        public static int Excluir(VendaDominio objVenda)
        {
            return new VendaDados().Excluir(objVenda);
        }

        public static int AddClienteCompra(ClienteCompraDominio objCompra)
        {
            return new VendaDados().AddClienteCompra(objCompra);

        }

        public static int AddProdutoEstoque(ProdutoEstoqueDominio objEstoque)
        {
            return new VendaDados().AddProdutoEstoque(objEstoque);
        }

        public static int DeleteProdutoEstoque(ProdutoEstoqueDominio objEstoque)
        {
            return new VendaDados().DeleteProdutoEstoque(objEstoque);
        }

        public List<VendaDominio> Lista()
        {
            return new VendaDados().Lista();
        }

    }
}
