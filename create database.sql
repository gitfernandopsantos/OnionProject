CREATE TABLE onion.clientes (
	documento varchar(14) NOT NULL,
	razao_social varchar(100) NOT NULL,
	logradouro varchar(100) NOT NULL,
	bairro varchar(50) NOT NULL,
	localidade varchar(100) NOT NULL,
	uf varchar(10) NULL,
	cep varchar(10) NOT NULL,
	CONSTRAINT clientes_pkey PRIMARY KEY (documento)
);


CREATE TABLE onion.pedidos (
	id_pedido int8 NOT NULL GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 9223372036854775807 START 1 CACHE 1 NO CYCLE),
	id_produto int8 NOT NULL,
	numero_pedido int4 NOT NULL,
	data_entrega date NOT NULL,
	frete money NOT NULL,
	CONSTRAINT pedidos_pkey PRIMARY KEY (id_pedido)
);

ALTER TABLE onion.pedidos ADD CONSTRAINT produtos_id_produto_fkey FOREIGN KEY (id_produto) REFERENCES onion.produtos(id_produto);


CREATE TABLE onion.produtos (
	id_produto int8 NOT NULL GENERATED ALWAYS AS IDENTITY( INCREMENT BY 1 MINVALUE 1 MAXVALUE 9223372036854775807 START 1 CACHE 1 NO CYCLE),
	tipo_produto varchar(100) NOT NULL,
	nome varchar(100) NOT NULL,
	documento_cliente varchar(14) NOT NULL,
	valor money NOT NULL,
	CONSTRAINT produtos_pkey PRIMARY KEY (id_produto)
);

ALTER TABLE onion.produtos ADD CONSTRAINT produtos_documento_cliente_fkey FOREIGN KEY (documento_cliente) REFERENCES onion.clientes(documento);