﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Vendas.Dominio;
using Controle_Vendas.Dados;

namespace Controle_Vendas.Dados
{
    public class VendaDados
    {
        public List<VendaDominio> Buscar(VendaDominio objVenda)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                con.Open();

                comando.CommandText = "SELECT VAS.CODIGO_VENDA, C.CODIGO_CLIENTE, C.NOME, P.CODIGO_PRODUTO, P.NOME_PRODUTO, VES.CODIGO_VENDEDOR, VES.NOME_VENDEDOR, VAS.CREDITO_LOJA, VAS.DATA_HORA, VAS.QUANTIDADE, P.PRECO_DE_LISTA, VAS.PRECO_TOTAL FROM TABELA_VENDAS AS VAS INNER JOIN TABELA_CLIENTES AS C ON VAS.CODIGO_CLIENTE = C.CODIGO_CLIENTE INNER JOIN TABELA_PRODUTOS AS P ON VAS.CODIGO_PRODUTO = P.CODIGO_PRODUTO INNER JOIN TABELA_VENDEDORES AS VES ON VAS.CODIGO_VENDEDOR = VES.CODIGO_VENDEDOR WHERE NOME LIKE @NOME";

                comando.Parameters.Add("NOME", SqlDbType.VarChar).Value = objVenda.NomeCliente + "%";

                comando.Connection = con;

                SqlDataReader dr;
                List<VendaDominio> lista = new List<VendaDominio>();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        VendaDominio dado = new VendaDominio();

                        dado.CodigoVenda = Convert.ToInt32(dr["CODIGO_VENDA"]);
                        dado.CodigoCliente = Convert.ToInt32(dr["CODIGO_CLIENTE"]);
                        dado.CodigoProduto = Convert.ToInt32(dr["CODIGO_PRODUTO"]);
                        dado.CodigoVendedor = Convert.ToInt32(dr["CODIGO_VENDEDOR"]);
                        dado.CreditoLoja = Convert.ToDouble(dr["CREDITO_LOJA"]);
                        dado.NomeCliente = Convert.ToString(dr["NOME"]);
                        dado.NomeProduto = Convert.ToString(dr["NOME_PRODUTO"]);
                        dado.NomeVendedor = Convert.ToString(dr["NOME_VENDEDOR"]);
                        dado.DataHora = Convert.ToString(dr["DATA_HORA"]);
                        dado.Quantidade = Convert.ToInt32(dr["QUANTIDADE"]);
                        dado.Preco = Convert.ToDouble(dr["PRECO_DE_LISTA"]);
                        dado.PrecoTotal = Convert.ToDouble(dr["PRECO_TOTAL"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public int AddClienteCompra(ClienteCompraDominio objCompra)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                con.Open();

                comando.CommandText = "INSERT INTO TABELA_CLIENTE_COMPRAS ([CODIGO_CLIENTE], [CODIGO_PRODUTO], [NOME_PRODUTO], [QUANTIDADE], [CREDITO_LOJA], [LIMITE_CREDITO], [PRECO], [PRECO_TOTAL], [DATA_HORA], [PRIMEIRA_COMPRA]) VALUES (@CODIGO_CLIENTE, @CODIGO_PRODUTO, @NOME_PRODUTO, @QUANTIDADE, @CREDITO_LOJA, @LIMITE_CREDITO, @PRECO, @PRECO_TOTAL, @DATA_HORA, @PRIMEIRA_COMPRA)";

                comando.Parameters.Add("CODIGO_CLIENTE", SqlDbType.Int).Value = objCompra.CodigoCliente;
                comando.Parameters.Add("CODIGO_PRODUTO", SqlDbType.Int).Value = objCompra.CodigoProduto;
                comando.Parameters.Add("NOME_PRODUTO", SqlDbType.VarChar).Value = objCompra.NomeProduto;
                comando.Parameters.Add("QUANTIDADE", SqlDbType.Int).Value = objCompra.Quantidade;
                comando.Parameters.Add("CREDITO_LOJA", SqlDbType.Decimal).Value = objCompra.CreditoLoja;
                comando.Parameters.Add("LIMITE_CREDITO", SqlDbType.Money).Value = objCompra.LimiteCredito;
                comando.Parameters.Add("PRECO", SqlDbType.Decimal).Value = objCompra.Preco;
                comando.Parameters.Add("PRECO_TOTAL", SqlDbType.Decimal).Value = objCompra.PrecoTotal;
                comando.Parameters.Add("DATA_HORA", SqlDbType.DateTime).Value = objCompra.DataHora;
                comando.Parameters.Add("PRIMEIRA_COMPRA", SqlDbType.Decimal).Value = objCompra.PrimeiraCompra;


                comando.Connection = con;

                int qtd = comando.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public List<ClienteDominio> BuscaCliente(ClienteDominio objCliente)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                con.Open();

                comando.CommandText = "SELECT CODIGO_CLIENTE, NOME, LIMITE_CREDITO FROM TABELA_CLIENTES WHERE CPF = @CPF";

                comando.Parameters.Add("CPF", SqlDbType.VarChar).Value = objCliente.Cpf;


                comando.Connection = con;

                SqlDataReader dr;
                List<ClienteDominio> lista = new List<ClienteDominio>();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ClienteDominio dado = new ClienteDominio();

                        dado.CodigoCliente = Convert.ToInt32(dr["CODIGO_CLIENTE"]);
                        dado.Nome = Convert.ToString(dr["NOME"]);
                        dado.LimiteCredito = Convert.ToString(dr["LIMITE_CREDITO"]); 

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public List<ProdutoDominio> BuscaProduto(ProdutoDominio objProduto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                con.Open();

                comando.CommandText = "SELECT NOME_PRODUTO, PRECO_DE_LISTA FROM TABELA_PRODUTOS WHERE CODIGO_PRODUTO = @CODIGO_PRODUTO";

                comando.Parameters.Add("CODIGO_PRODUTO", SqlDbType.Int).Value = objProduto.CodigoProduto;


                comando.Connection = con;

                SqlDataReader dr;
                List<ProdutoDominio> lista = new List<ProdutoDominio>();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProdutoDominio dado = new ProdutoDominio();

                        dado.NomeProduto = Convert.ToString(dr["NOME_PRODUTO"]);
                        dado.PrecoDeLista = Convert.ToDouble(dr["PRECO_DE_LISTA"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public List<VendedorDominio> BuscaVendedor(VendedorDominio objVendedor)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                con.Open();

                comando.CommandText = "SELECT NOME_VENDEDOR FROM TABELA_VENDEDORES WHERE CODIGO_VENDEDOR = @CODIGO_VENDEDOR";

                comando.Parameters.Add("CODIGO_VENDEDOR", SqlDbType.Int).Value = objVendedor.CodigoVendedor;


                comando.Connection = con;

                SqlDataReader dr;
                List<VendedorDominio> lista = new List<VendedorDominio>();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        VendedorDominio dado = new VendedorDominio();

                        dado.NomeVendedor = Convert.ToString(dr["NOME_VENDEDOR"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public List<ClienteCompraDominio> BuscaClienteCompra(ClienteCompraDominio objCompra)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                con.Open();

                comando.CommandText = "SELECT LIMITE_CREDITO, CODIGO_CLIENTE, CREDITO_LOJA FROM TABELA_CLIENTE_COMPRAS WHERE CODIGO_CLIENTE = @CODIGO_CLIENTE";

                comando.Parameters.Add("CODIGO_CLIENTE", SqlDbType.Int).Value = objCompra.CodigoCliente;

                comando.Connection = con;

                SqlDataReader dr;
                List<ClienteCompraDominio> lista = new List<ClienteCompraDominio>();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ClienteCompraDominio dado = new ClienteCompraDominio();
                        
                        dado.LimiteCredito = Convert.ToDouble(dr["LIMITE_CREDITO"]);
                        dado.CodigoCliente = Convert.ToInt32(dr["CODIGO_CLIENTE"]); 
                        dado.CreditoLoja = Convert.ToDouble(dr["CREDITO_LOJA"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public int Inserir(VendaDominio objVenda)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                con.Open();

                comando.CommandText = "INSERT INTO TABELA_VENDAS ([CODIGO_CLIENTE], [CODIGO_PRODUTO], [CODIGO_VENDEDOR], [CREDITO_LOJA], [DATA_HORA], [PRIMEIRA_COMPRA], [QUANTIDADE], [PRECO_TOTAL]) VALUES (@CODIGO_CLIENTE, @CODIGO_PRODUTO, @CODIGO_VENDEDOR, @CREDITO_LOJA, @DATA_HORA, @PRIMEIRA_COMPRA, @QUANTIDADE, @PRECO_TOTAL)";

                comando.Parameters.Add("CODIGO_CLIENTE", SqlDbType.Int).Value = objVenda.CodigoCliente;
                comando.Parameters.Add("CODIGO_PRODUTO", SqlDbType.Int).Value = objVenda.CodigoProduto;
                comando.Parameters.Add("CODIGO_VENDEDOR", SqlDbType.Int).Value = objVenda.CodigoVendedor;
                comando.Parameters.Add("CREDITO_LOJA", SqlDbType.Decimal).Value = objVenda.CreditoLoja;
                comando.Parameters.Add("DATA_HORA", SqlDbType.DateTime).Value = objVenda.DataHora;
                comando.Parameters.Add("PRIMEIRA_COMPRA", SqlDbType.Decimal).Value = objVenda.PrimeiraCompra;
                comando.Parameters.Add("QUANTIDADE", SqlDbType.Int).Value = objVenda.Quantidade;
                comando.Parameters.Add("PRECO_TOTAL", SqlDbType.Float).Value = objVenda.PrecoTotal;

                comando.Connection = con;

                int qtd = comando.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public int Editar(VendaDominio objVenda)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                con.Open();

                comando.CommandText = "UPDATE TABELA_VENDAS SET CODIGO_CLIENTE = @CODIGO_CLIENTE, CODIGO_PRODUTO = @CODIGO_PRODUTO, CODIGO_VENDEDOR = @CODIGO_VENDEDOR, CREDITO_LOJA = @CREDITO_LOJA, DATA_HORA = @DATA_HORA, QUANTIDADE = @QUANTIDADE, PRECO_TOTAL = @PRECO_TOTAL WHERE CODIGO_VENDA = @CODIGO_VENDA";

                comando.Parameters.Add("CODIGO_VENDA", SqlDbType.Int).Value = objVenda.CodigoVenda;
                comando.Parameters.Add("CODIGO_CLIENTE", SqlDbType.VarChar).Value = objVenda.CodigoCliente;
                comando.Parameters.Add("CODIGO_PRODUTO", SqlDbType.Int).Value = objVenda.CodigoProduto;
                comando.Parameters.Add("CODIGO_VENDEDOR", SqlDbType.Int).Value = objVenda.CodigoVendedor;
                comando.Parameters.Add("CREDITO_LOJA", SqlDbType.Float).Value = objVenda.CreditoLoja;
                comando.Parameters.Add("DATA_HORA", SqlDbType.VarChar).Value = objVenda.DataHora;
                comando.Parameters.Add("QUANTIDADE", SqlDbType.Int).Value = objVenda.Quantidade;
                comando.Parameters.Add("PRECO_TOTAL", SqlDbType.Float).Value = objVenda.PrecoTotal;

                comando.Connection = con;

                int qtd = comando.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        public int Excluir(VendaDominio objVenda)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                con.Open();

                comando.CommandText = "DELETE FROM TABELA_VENDAS WHERE CODIGO_VENDA = @CODIGO_VENDA";

                comando.Parameters.Add("CODIGO_VENDA", SqlDbType.Int).Value = objVenda.CodigoVenda;

                comando.Connection = con;

                int qtd = comando.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            };
        }

        public List<VendaDominio> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;

                con.Open();

                comando.CommandText = "SELECT VAS.CODIGO_VENDA, C.CODIGO_CLIENTE, C.NOME, P.CODIGO_PRODUTO, P.NOME_PRODUTO, VES.CODIGO_VENDEDOR, VES.NOME_VENDEDOR, VAS.CREDITO_LOJA, VAS.DATA_HORA, VAS.QUANTIDADE, P.PRECO_DE_LISTA, VAS.PRECO_TOTAL FROM TABELA_VENDAS AS VAS INNER JOIN TABELA_CLIENTES AS C ON VAS.CODIGO_CLIENTE = C.CODIGO_CLIENTE INNER JOIN TABELA_PRODUTOS AS P ON VAS.CODIGO_PRODUTO = P.CODIGO_PRODUTO INNER JOIN TABELA_VENDEDORES AS VES ON VAS.CODIGO_VENDEDOR = VES.CODIGO_VENDEDOR ORDER BY C.NOME";

                comando.Connection = con;

                SqlDataReader dr;
                List<VendaDominio> lista = new List<VendaDominio>();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        VendaDominio dado = new VendaDominio();

                        dado.CodigoVenda = Convert.ToInt32(dr["CODIGO_VENDA"]);
                        dado.CodigoCliente = Convert.ToInt32(dr["CODIGO_CLIENTE"]);
                        dado.CodigoProduto = Convert.ToInt32(dr["CODIGO_PRODUTO"]);
                        dado.CodigoVendedor = Convert.ToInt32(dr["CODIGO_VENDEDOR"]);
                        dado.CreditoLoja = Convert.ToDouble(dr["CREDITO_LOJA"]);
                        dado.NomeCliente = Convert.ToString(dr["NOME"]);
                        dado.NomeProduto = Convert.ToString(dr["NOME_PRODUTO"]);
                        dado.NomeVendedor = Convert.ToString(dr["NOME_VENDEDOR"]);
                        dado.DataHora = Convert.ToString(dr["DATA_HORA"]);
                        dado.Quantidade = Convert.ToInt32(dr["QUANTIDADE"]);
                        dado.Preco = Convert.ToDouble(dr["PRECO_DE_LISTA"]);
                        dado.PrecoTotal = Convert.ToDouble(dr["PRECO_TOTAL"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

    }
}
