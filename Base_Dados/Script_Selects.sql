SELECT VAS.CODIGO_VENDA, C.CODIGO_CLIENTE, C.NOME, P.CODIGO_PRODUTO, P.NOME_PRODUTO, 
VES.CODIGO_VENDEDOR, VES.NOME_VENDEDOR, VAS.CREDITO_LOJA, VAS.DATA_HORA FROM TABELA_VENDAS AS VAS INNER JOIN TABELA_CLIENTES AS C
ON VAS.CODIGO_CLIENTE = C.CODIGO_CLIENTE
INNER JOIN TABELA_PRODUTOS AS P
ON VAS.CODIGO_PRODUTO = P.CODIGO_PRODUTO
INNER JOIN TABELA_VENDEDORES AS VES
ON VAS.CODIGO_VENDEDOR = VES.CODIGO_VENDEDOR