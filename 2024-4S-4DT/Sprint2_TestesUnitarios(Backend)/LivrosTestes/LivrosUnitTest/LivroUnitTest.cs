using Xunit;

namespace LivrosUnit.Test
    {
    public class LivroUnitTest
        {
        [Fact]
        public void AddLivro()
            {
            string[] result = Livros.Livro.AdicionarLivro("7 Desafios para ser um rei");

            string[] expectedValue = result;

            Assert.Equal(expectedValue, result);
            }
        }
    }