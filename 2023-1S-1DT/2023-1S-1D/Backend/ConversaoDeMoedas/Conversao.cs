namespace ConversaoDeMoedas
{
    public class Conversao
    {
        //propriedade estática
        public static float Moeda {get; set;}
        
        //métodos estáticos
        public static float RealToDollar (float real)
        {
            Moeda = real;

            float Dollar = (Moeda * 0.2f);

            return Dollar;
        }

        public static float RealToEuro (float real)
        {
            Moeda = real;

            float Euro = (Moeda * 0.18f);

            return Euro;
        }

        public static float RealToIene (float real)
        {
            Moeda = real;

            float Iene = (Moeda * 27.08f);

            return Iene;
        }
    }
}