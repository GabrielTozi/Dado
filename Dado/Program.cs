using System;

namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp = 0, pes1 = 0, pes2 = 0, cont = 1, i = 0;
            double apo1 = 0, apo2 = 0, caixa = 0, apo3 = 0, apo4 = 0;
            Random D1 = new Random();
            Random D2 = new Random();
            Dado inicio = new Dado();
            int soma = 0, d2 = 0;
           

            Console.WriteLine("Começar o jogo de dados?\nS/N");
            //resp.Levi = Console.ReadLine();
            inicio.Inicio = Console.ReadLine();
            inicio.comecar();
            
            //decidir quem começa
            for (i = 0; i < 2; i++)
            {
                int d1 = D1.Next(1, 12);

                if (d1 == 2 || d1 == 3 || d1 == 12)
                {

                    Console.WriteLine("\n" + i + "° lançador\nresultado da soma: " + d1);
                    Console.WriteLine("Parece que você foi azarado :(");
                }
                else
                {
                    if (d1 == 7 || d1 == 11)
                    {
                        Console.WriteLine("\n" + (i + 1) + "° lançador\nresultado da soma: " + d1);
                        Console.WriteLine("Temos um sortudo vencedor :)");
                    }
                    else
                    {
                        Console.WriteLine("\n" + (i + 1) + "lançador\nresultado da soma: " + d1);
                        resp = d1;
                        if (i == 0)
                        {
                            pes1 = resp;
                        }
                        else
                        {
                            pes2 = resp;
                        }
                    }
                }
            }
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            if (pes1 > pes2)
            {
                Console.WriteLine("\nO primeiro lançador irá começar");
                inicio.jogada = "lançador 1";
            }
            else
            {
                if (pes2 > pes1)
                {
                    Console.WriteLine("\nO segundo lançador irá começar");
                    inicio.jogada = "lançador 2";
                }
                else
                {
                    Console.WriteLine("Parece que houve empate :/");
                }
            }

            inicio.Pont1 = pes1;
            inicio.Pont2 = pes2;

            Console.WriteLine("Lançador 1, inserir quanto de dinheiro?");
            apo1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lançador 2, inserir quanto de dinheiro?");
            apo2 = double.Parse(Console.ReadLine());

            //jogo
            do
            {

                for (int cont2 = 0; cont2 < 1; cont2++)
                {
                    Console.WriteLine("qual o valor a aposta?");
                    Console.WriteLine("jogador 1:");
                    apo3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual o valor a aposta?");
                    Console.WriteLine("jogador 2:");
                    apo4 = double.Parse(Console.ReadLine());
                    if (apo3 != apo4)
                    {
                        Console.WriteLine("\nta errado isso ae, tem que ser igual");
                        cont2--;
                    }
                }

                Console.WriteLine("vamos iniciar o jogo");

                

            } while (cont != 0);

            Problema p = new Problema();

            Random r = new Random();
            int x =0, y = 0, contador = 0;

            x = r.Next(6);
            y = r.Next(6);

            while (contador <2)
            {
                x = r.Next(6);
                y = r.Next(6);

                contador++;


                if (contador == 1)
                {
                    p.JogadaJ1(x, y);
                }
                else
                {
                    p.JogadaJ2(x, y);
                }
            }
           

          

           
           


        }

    }
}
