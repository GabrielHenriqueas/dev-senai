namespace ValidarEmail.Teste
    {
    public class UnitTest1
        {
        [Fact]
        public void Test1()
            {
            bool validado = ValidaEmail.ValidateEmail("sim123@email.com");

            Assert.True(validado);
            }
        }
    }