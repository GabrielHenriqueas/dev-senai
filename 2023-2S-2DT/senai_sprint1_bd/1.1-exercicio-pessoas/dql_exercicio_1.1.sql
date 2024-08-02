--ATIVIDADE DQL

--- listar as pessoas em ordem alfabética reversa, mostrando seus telefones, seus e-mails e suas CNHs

SELECT Pessoa.Nome, Telefone.Numero AS Email.Email, Pessoa.Cnh
FROM Pessoa, Email, Telefone
WHERE Pessoa.IdPessoa = Email.IdPessoa AND Pessoa.IdPessoa = Telefone.IdPessoa
ORDER BY
NomePessoa DESC

SELECT P.Nome AS [Name], Telefones.Telefone AS Tel, E.Email AS Email, P.CNH
FROM Pessoas AS P, Emails AS E, Telefones
WHERE P.PessoaID = E.PessoaID AND P.PessoaID = Telefones.PessoaID
ORDER BY E.Email ASC


SELECT
	P.Nome,
	Telefone.Numero AS Telefone,
	E.Email AS Email,
	P.CNH

FROM
	Pessoa AS P,
	Email AS E,
	Telefone

WHERE
	P.IdPessoa = E.IdPessoa
	AND P.IdPessoa = Telefone.IdPessoa

ORDER BY
Nome DESC

SELECT * FROM Pessoa;

INSERT INTO Pessoa (Nome, CHN)
VALUES
	('Gabriel','51651651'),
	('Vinicius','59148429'),
	('Vitória','516514545'),
	('Gustavo','51651652');