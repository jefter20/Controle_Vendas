USE [CONTROLE_VENDAS]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TABELA_CLIENTES](
	[CODIGO_CLIENTE] int PRIMARY KEY IDENTITY NOT NULL,
	[NOME] varchar(100) NOT NULL,
	[CPF] varchar(11) NOT NULL,
	[ENDERECO_1] varchar(150) NOT NULL,
	[ENDERECO_2] varchar(150) NULL,
	[BAIRRO] varchar(50) NOT NULL,
	[CIDADE] varchar(50) NOT NULL,
	[UF] varchar(2) NOT NULL,
	[CEP] varchar(8) NOT NULL,
	[DATA_NASCIMENTO] date NOT NULL,
	[SEXO] varchar(1) NOT NULL,
	[LIMITE_CREDITO] money NULL,
	[VOLUME_COMPRA] float NULL
	)


