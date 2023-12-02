CREATE TABLE clientes (
	documento VARCHAR ( 14 ) PRIMARY key not null ,
	razao_social VARCHAR ( 100 ) NOT NULL,
	logradouro VARCHAR ( 100 ) NOT NULL,
	bairro VARCHAR ( 50 ) NOT NULL,
	localidade VARCHAR ( 100 ) NOT NULL,
	uf VARCHAR ( 10 ) NULL,
	cep VARCHAR ( 10 ) NOT NULL,
	produto VARCHAR ( 100 ) NOT NULL
);



CREATE TABLE onion.produtos (
	id_produto int8 NOT NULL GENERATED ALWAYS AS identity primary key,
	tipo_produto varchar(100) NOT NULL,
	nome varchar(100) NOT NULL,
	documento_cliente varchar(14) not NULL,
	valor money not NULL
);

CREATE SEQUENCE produtos_id_produto_seq
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 9223372036854775807
	START 1
	CACHE 1
	NO CYCLE;


ALTER TABLE onion.produtos ADD CONSTRAINT produtos_documento_cliente_fkey FOREIGN KEY (documento_cliente) REFERENCES onion.clientes(documento);

CREATE TABLE onion.pedidos (
	id_pedido int8 NOT NULL GENERATED ALWAYS AS identity primary key,
	id_produto int8 not null,
	numero_pedido int4 NOT NULL,
	data_entrega date NOT NULL,
	frete money NOT NULL
);

CREATE SEQUENCE pedidos_id_pedido_seq
	INCREMENT BY 1
	MINVALUE 1
	MAXVALUE 9223372036854775807
	START 1
	CACHE 1
	NO CYCLE;

ALTER TABLE onion.pedidos ADD CONSTRAINT produtos_id_produto_fkey FOREIGN KEY (id_produto) REFERENCES onion.produtos(id_produto);







ADD COLUMN documento_cliente varchar(14) REFERENCES clientes(documento);

ALTER TABLE pedidos
ADD COLUMN id_produto bigint REFERENCES produtos(id_produto);