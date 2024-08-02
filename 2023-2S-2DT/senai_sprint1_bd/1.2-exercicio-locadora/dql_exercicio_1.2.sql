--DQL - Data Query Language

--listar todos os alugueis mostrando as datas de início e 
--fim, o nome do cliente que alugou e nome do modelo do carro

--listar os alugueis de um determinado cliente mostrando 
--seu nome, as datas de início e fim e o nome do 
--modelo do carro

select Aluguel.DataInicio, Aluguel.DataFinal
from Cliente 
inner join Aluguel on Cliente.IdCliente = Aluguel.IdCliente

select Cliente.Nome
from Aluguel 
inner join Cliente on Cliente.IdCliente = Aluguel.IdCliente

select Veiculo.Placa
from Aluguel 
inner join Veiculo on Veiculo.IdVeiculo = Aluguel.IdVeiculo
