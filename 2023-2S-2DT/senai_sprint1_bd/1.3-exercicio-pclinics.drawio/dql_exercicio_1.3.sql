--select * from cientes;
--select * from produtos;

--exemplos de filtragem de dados

--select nome, estoque from produtos where estoque <= 60;
--select nome, preco from produtos where preco >= 20 and preco <= 30 order by nome;
--select * from produtos where nome like '%camiseta%';
--select nome, preco from produtos where nome like '%esport%';
--------------------------------------------------------------------------------
--DQL - Data Query Language

--listar todos os veterinários (nome e CRMV) de uma clínica (razão social)
SELECT Veterinario.Nome AS Veterinario, Veterinario.CRMV, Clinica.RazaoSocial
FROM Veterinario
INNER JOIN Clinica on Clinica.IdClinica = Veterinario.IdClinica
WHERE Clinica.RazaoSocial = 'PetLandia';

--listar todas as raças que começam com a letra S
SELECT Raca.Descricao as Raca
FROM Raca
WHERE Descricao LIKE 'S%'

--listar todos os tipos de pet que terminam com a letra O
SELECT TipoPet.Descricao as [Tipo de Pet]
FROM TipoPet
WHERE Descricao LIKE '%o'

--listar todos os pets mostrando os nomes dos seus donos
SELECT Pet.Nome AS [Nome do Pet], Dono.Nome AS [Nome do Dono]
FROM Pet
INNER JOIN Dono on Pet.IdDono = Dono.IdDono;


--listar todos os atendimentos mostrando o nome do veterinário que atendeu, o nome, a raça e o tipo do pet que foi atendido, o nome do dono do pet e o nome da clínica onde o pet foi atendido
Select




----------------------------------------------------------------------------
SELECT Veterinario.Nome as Veterinario from Veterinario
inner join Clinica on Clinica.IdClinica = Veterinario.IdClinica;

SELECT IdDono
FROM Dono
INNER JOIN Pet
ON Dono.IdDono = Pet.IdDono;
