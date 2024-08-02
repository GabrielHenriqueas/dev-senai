--DML - INSERIR DADOS NA TABELA

--USAR O BANCO CRIADO
USE Exercicio_1_4;

--INSERIR DADOS NA TABELA
INSERT INTO Artista(Nome)
VALUES ('Mc Kauan'), ('Veigh'), ('Kyan'), ('Matuí')

INSERT INTO Usuario(Nome, Email, Senha, Permissao)
VALUES ('Gabriel', 'gabriel@example.com', '123', '0'), ('Mateus', 'mateus@example.com', '123', '0'), ('Felipe', 'felipe@example.com', '123', '0')

INSERT INTO Estilos(Nome)
VALUES ('Funk'), ('Trap')

INSERT INTO Album(IdArtista, Titulo, DataLancamento, Localizacao, QtdMinutos, Ativos)
VALUES (2, 'Dos Prédio Deluxe', '01/07/2023', 'Brasil', '90min', '1'), (3, 'Um quebrada intlgt', '01/07/2023', 'Brasil', '90min', '1'), (4, 'Maquina do Tempo', '01/07/2023', 'Brasil', '90min', '1')

INSERT INTO AlbunsEstilos(IdAlbum, IdEstilos)
VALUES (1, 2), (2, 2), (3, 2)

--INSERT INTO Pessoa VALUES('Carlos','123455676')

SELECT * FROM Artista
SELECT * FROM Usuario
SELECT * FROM Estilos
SELECT * FROM Album
SELECT * FROM AlbunsEstilos