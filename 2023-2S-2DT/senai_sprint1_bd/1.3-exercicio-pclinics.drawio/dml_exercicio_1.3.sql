--DML - INSERIR DADOS NA TABELA

--USAR O BANCO CRIADO
USE Exercicio_1_3;

--INSERIR DADOS NA TABELA
INSERT INTO Clinica(Endereco, RazaoSocial)
VALUES ('Rua ABC, 105', 'PetLandia')

INSERT INTO Dono(Nome)
VALUES ('Valmir'), ('Gabriel'), ('Vitória')

INSERT INTO TipoPet(Descricao)
VALUES ('Ave'), ('Cachorro'), ('Gato')

INSERT INTO Raca(Descricao)
VALUES ('Piriquito'), ('RND'), ('Persa')

INSERT INTO Veterinario(IdClinica, Nome, CRMV)
VALUES (1, 'Valter Branco', '25252525'), (1, 'Walter White', '52525252')

INSERT INTO Pet(IdTipoPet, IdRaca, IdDono, Nome, DataNascimento)
VALUES (1, 1, 1, 'Piriquinildos', '11/11/11'), (2, 2, 2, 'Pandora', '12/04/10'), (3, 3, 3, 'Venom', '11/11/11');

INSERT INTO Atendimentos(IdVeterinario, IdPet, Descricao, [Data])
VALUES (1, 1, '123456', '03/08/2023'), (1, 2, '123457', '03/08/2023'), (1, 3, '123458', '03/08/2023');

--INSERT INTO Pessoa VALUES('Carlos','123455676')

SELECT * FROM Clinica
SELECT * FROM Veterinario
SELECT * FROM Atendimentos
SELECT * FROM Pet
SELECT * FROM Dono
SELECT * FROM TipoPet
SELECT * FROM Raca