CREATE TABLE contatos (
    id INTEGER PRIMARY KEY,
    nome VARCHAR(100),
    sobrenome VARCHAR(100),
    telefone NUMERIC,
    email VARCHAR(255)
);

CREATE TABLE evento (
    id INTEGER PRIMARY KEY,
    evento VARCHAR(255),
    data DATETIME,
    id_contato INTEGER,
    FOREIGN KEY (id_contato) REFERENCES contatos(id)
);

CREATE TABLE senhas (
    id INTEGER PRIMARY KEY,
    apelido VARCHAR(100),
    login VARCHAR(100),
    senha VARCHAR(255)
);

CREATE TABLE gastos (
    id INTEGER PRIMARY KEY,
    nome VARCHAR(255),
    valor NUMERIC,
    data DATETIME,
    descricao VARCHAR(500)
);

CREATE TABLE gasto_mensal (
    id INTEGER PRIMARY KEY,
    periodo_inicio DATE,
    periodo_fim DATE,
    valor NUMERIC
);
