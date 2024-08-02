--DML - INSERIR DADOS NA TABELA

--USAR O BANCO CRIADO
USE Exercicio_1_1;

--INSERIR DADOS NA TABELA
INSERT INTO Pessoa(Nome, CNH)
VALUES ('Carlos','1234312456'),('Eduardo','1234312457')

INSERT INTO Email(IdPessoa, Email)
VALUES (1,'carlos@email.com'),(2,'eduardo@email.com')

INSERT INTO Telefone(IdPessoa, Numero)
VALUES (1,'+55 11 954546322'),(2,'+55 11 954546323')

--INSERT INTO Pessoa VALUES('Carlos','123455676')

SELECT * FROM Pessoa
SELECT * FROM Email
SELECT * FROM Telefone