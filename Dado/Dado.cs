namespace Dado
{
    class Dado
    {
        //usar para calculo do resultado
        public int Result { get; set; }
        public void points(int Result)
        {
            this.Result = Result;
            
        }

        //pontos
        public int Pont1 { get; set; }
        public int Pont2 { get; set; }
        public int resultado { get; set; }

        public int Dado1 { get; set; }
        public int Dado2 { get; set; }



        //iniciar o jogo
        public string Inicio { get; set; }

        public void comecar(string Inicio = "s")
        {
            this.Inicio = Inicio;
            System.Console.WriteLine("\nVamos decidir quem é que vai começar :)");
        }

        public void Lancador1(int v1, int v2)
        {
            this.Dado1 = v1;
            this.Dado2 = v2;
            int soma = v1 + v2;
            System.Console.WriteLine("Jogada do Jogador 1 = " + soma);
        }

        public void Lancador2(int valor1, int valor2)
        {
            this.Dado1 = valor1;
            this.Dado2 = valor2;
            int soma = valor1 + valor2;
            System.Console.WriteLine("Jogada do Jogador 2 = " + soma);
            
        }



    }
}










