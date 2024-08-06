using Moq;
using ProdutoApiTest.Domains;
using ProdutoApiTest.Interface;
using ProdutoApiTest.Repositories;

namespace ProdutosApiTestUnit
{
    public class ProductsTest
    {
        /// <summary>
        /// Teste para a funcionalidade de listar todos os produtos
        /// </summary>
        [Fact]

        public void Get()
        {
            //Arrange

            //lista de produtos
            List<Products> productList = new List<Products>
            {
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 1", Price = 78 },
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 2", Price = 90 },
                new Products { IdProduct = Guid.NewGuid(), Name = "Produto 3", Price = 787 }

            };

            //Cria um objeto de simulação do tipo ProductRepository
            var mockRepository = new Mock<IProductsRepository>();
            //Configura o metodo Get para que retorne a lista mockada
            mockRepository.Setup(x => x.Get()).Returns(productList);

            //Act
            //Executando o metodo Get e atribui a resposta em result 
            var result = mockRepository.Object.Get();

            //Assert
            Assert.Equal(3, result.Count);
        }
    }
}