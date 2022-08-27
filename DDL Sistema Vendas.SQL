-- DDL, sistema Vendas
-- Criação: Alexandra C. Atelli em: 15/06/2022
-- Atualizado em: 27/05/2022

USE [master]
GO

CREATE DATABASE [vendas_db];


CREATE TABLE cliente(
	id_cliente int NOT NULL PRIMARY KEY IDENTITY(1,1),
	cpf varchar(11) unique NOT NULL,
	nomeCliente varchar(100) not null,
	telefone varchar(15) not null,
	email varchar(100) not null);

CREATE TABLE produto(
	id_produto int NOT NULL PRIMARY KEY IDENTITY(1,1),
	codEAN int NOT NULL,
	nomeProduto varchar(100) not null,
	preco real not null,
	estoque int not null default 0);
	
CREATE TABLE venda(
	id_venda int NOT NULL PRIMARY KEY IDENTITY(1,1),
	id_cliente int NOT NULL,
	valorTotal real NOT NULL);

	ALTER TABLE venda ADD CONSTRAINT fk_cliente FOREIGN KEY(id_cliente) REFERENCES cliente(id_cliente);

CREATE TABLE itemVenda(
	id_itemVenda int PRIMARY KEY IDENTITY(1,1),
	id_venda int NOT NULL,
	id_produto int NOT NULL,
	valorUnitario real NOT NULL,
	quantidade int NOT NULL,
	valorTotal real NOT NULL);

ALTER TABLE itemVenda ADD  CONSTRAINT fk_itemProduto FOREIGN KEY(id_produto) REFERENCES produto (id_produto);
ALTER TABLE itemVenda ADD  CONSTRAINT fk_itemVenda FOREIGN KEY(id_venda) REFERENCES venda (id_venda);

ALTER TABLE [dbo].[produto]  WITH CHECK ADD  CONSTRAINT [Falta_estoque] CHECK  (([estoque]>=(0)))


----- Manutenção de estoque realizado por triggers de acordo com o evento

CREATE TRIGGER [dbo].[TGR_ITEMVENDA_ISERIR] ON [dbo].[itemVenda]
FOR INSERT
AS
BEGIN
    DECLARE
    @VID_PROD  int,
    @VQTDE   int

    --Inserted faz refencia a um registro transitório temporário criado durante o processo de inserção pelo banco de dados
	SELECT @VID_PROD = id_produto, @VQTDE = quantidade FROM INSERTED

    UPDATE produto SET estoque = estoque - @VQTDE WHERE id_produto = @VID_PROD
END



CREATE TRIGGER [dbo].[TGR_ITEMVENDAS_APAGAR] ON [dbo].[itemVenda]
FOR DELETE
AS
BEGIN
    DECLARE
    @VID_PROD  int,
    @VQTDE   int

    --Inserted faz refencia a um registro transitório temporário criado durante o processo de inserção pelo banco de dados
	SELECT @VID_PROD = id_produto, @VQTDE = quantidade FROM DELETED

    UPDATE produto SET estoque = estoque + @VQTDE WHERE id_produto = @VID_PROD
END



CREATE TRIGGER [dbo].[TGR_ITEMVENDAS_ATUALIZAR] ON [dbo].[itemVenda]
FOR UPDATE
AS
BEGIN
    DECLARE
    @VID_PROD  int,
    @VQTDE_OLD   int,
	@VQTDE int,
	@diferenca int

    --Deleted faz refencia a um registro transitório temporário criado durante o processo de inserção pelo banco de dados
	SELECT @VID_PROD = id_produto, @VQTDE = quantidade FROM INSERTED;
	--Valor antigo
	SELECT @VQTDE_OLD = quantidade FROM DELETED;

	--Diferença sem sinal
	set @diferenca = abs(@VQTDE_OLD - @VQTDE);

	--Se quantidade antiga é maior que a inserida = estoque deve aumentar.
	if (@diferenca != 0) -- Se houve mudança na quantiade
		if (@VQTDE_OLD > @VQTDE )
			UPDATE produto SET estoque = estoque + @diferenca WHERE id_produto = @VID_PROD;
		else --estoque deve diminuir
	    UPDATE produto SET estoque = estoque - @diferenca WHERE id_produto = @VID_PROD;

END





