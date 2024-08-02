namespace ControleDeInventario.Teste
    {
    public class UnitTest1
        {
        //[Fact]
        //public void Test1()
        //    {
        //    ClasseControleDeInventario.AdicionarProduto("Bola");
        //    ClasseControleDeInventario.AdicionarProduto("Bola");
        //    ClasseControleDeInventario.AdicionarProduto("Espada");

        //    var qtdBola = ClasseControleDeInventario.ObterQuantidade("Bola");
        //    var qtdEspada = ClasseControleDeInventario.ObterQuantidade("Espada");

        //    var expectedbola = 4;
        //    var expectedEspada = 1;

        //    Assert.True(qtdBola == expectedbola && qtdEspada == expectedEspada);
        //    }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Test2(int value)
            {
            ClasseControleDeInventario.AdicionarProduto("Bola");
            ClasseControleDeInventario.AdicionarProduto("Bola");

            var qtdBola = ClasseControleDeInventario.ObterQuantidade("Bola");

            Assert.Equal(value, qtdBola);
            }
        }
    }