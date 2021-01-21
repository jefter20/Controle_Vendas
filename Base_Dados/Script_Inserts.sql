/*Inserindo na Tabela de Produtos*/
INSERT INTO TABELA_PRODUTOS (NOME_PRODUTO, EMBALAGEM, TAMANHO, SABOR, [QUANTIDADE_EM_ESTOQUE], [PRECO_DE_LISTA]) 
VALUES ('Suco Natural de Laranja 600ml', 'Garrafa', '600ml', 'Laranja', 100000, 5.50)

INSERT INTO TABELA_PRODUTOS (NOME_PRODUTO, EMBALAGEM, TAMANHO, SABOR, [QUANTIDADE_EM_ESTOQUE], [PRECO_DE_LISTA]) 
VALUES ('Refrigerante de Coca 2 lts', 'PET', '2 lts', 'Coca', 300000, 13.99)


/*Inserindo na Tabela de Vendedores*/
INSERT INTO TABELA_VENDEDORES (NOME_VENDEDOR, PERCENTUAL_COMISSAO, DATA_ADMISSAO, STATUS_FERIAS, USUARIO, SENHA) 
VALUES ('Carlos Marinho', 0.1, '2013-03-25', 0, 'carlos', 123)

INSERT INTO TABELA_VENDEDORES (NOME_VENDEDOR, PERCENTUAL_COMISSAO, DATA_ADMISSAO, STATUS_FERIAS, USUARIO, SENHA) 
VALUES ('Maria de Lurdes', 0.11, '2014-01-01', 0, 'maria', 123)

INSERT INTO TABELA_VENDEDORES (NOME_VENDEDOR, PERCENTUAL_COMISSAO, DATA_ADMISSAO, STATUS_FERIAS, USUARIO, SENHA) 
VALUES ('Ana Brand�o', 0.07, '2019-01-12', 0, 'ana', 123)


/*Inserindo na Tabela de Clientes*/
USE CONTROLE_VENDAS
INSERT INTO TABELA_CLIENTES (NOME, CPF, ENDERECO_1, ENDERECO_2, BAIRRO, CIDADE, UF, CEP, DATA_NASCIMENTO, SEXO, LIMITE_CREDITO, VOLUME_COMPRA, USUARIO, SENHA) 
VALUES ('Carlos Alberto', '27398909830', 'Rua A', 'A', 'Vila', 'S�o Paulo', 'SP', '00111000', '30/03/1993', 'M', 20000, 1000, 'carlos01', '123')

INSERT INTO TABELA_CLIENTES (NOME, CPF, ENDERECO_1, ENDERECO_2, BAIRRO, CIDADE, UF, CEP, DATA_NASCIMENTO, SEXO, LIMITE_CREDITO, VOLUME_COMPRA, USUARIO, SENHA) 
VALUES ('Marco Alves', '27398909070', 'Rua B', 'A', 'Vila', 'S�o Paulo', 'SP', '00132100', '21/03/1993', 'M', 10000, 8000, 'marco01', '123')



