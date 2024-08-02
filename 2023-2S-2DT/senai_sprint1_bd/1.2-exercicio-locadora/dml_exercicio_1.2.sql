--DML - INSERIR DADOS NA TABELA

--USAR O BANCO CRIADO
USE Exercicio_1_2;

--INSERIR DADOS NA TABELA
INSERT INTO Cliente(Nome, CPF)
VALUES ('Carlos','20030040056'),('Eduardo','20030040057')

INSERT INTO Empresa(Nome)
VALUES ('MOVIDA')

INSERT INTO Modelo(Nome)
VALUES ('GOL'),('X6')

INSERT INTO Marca(Nome)
VALUES ('VW'),('BMW')

INSERT INTO Veiculo(IdEmpresa, IdModelo, IdMarca, Placa)
VALUES (1, 1, 1, 'DIZ-6530'), (1, 2, 2, 'DIZ-6540')

INSERT INTO Aluguel(IdVeiculo, IdCliente, Protocolo, DataInicio, DataFim)
VALUES (1, 1, '123456', '25-10-2023', '25-11-2023'), (1, 2, '123457', '25-10-2023', '25-11-2023'), (2, 1, '123458', '25-10-2023', '25-11-2023')

--INSERT INTO Pessoa VALUES('Carlos','123455676')

SELECT * FROM Cliente
SELECT * FROM Aluguel
SELECT * FROM Empresa
SELECT * FROM Veiculo
SELECT * FROM Modelo
SELECT * FROM Marca