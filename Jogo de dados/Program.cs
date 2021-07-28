using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string jogador1, jogador2;
            int aposta1 = 0, aposta2 = 0;

            Console.WriteLine("Jogador 1");
            Console.WriteLine(" digite seu nome");
            jogador1 = Console.ReadLine();
            Console.WriteLine("Quanto você vai querer apostar?");
            aposta1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Jogador 2");
            Console.WriteLine(" digite seu nome");
            jogador2 = Console.ReadLine();
            Console.WriteLine("Quanto você vai querer apostar?");
            aposta2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Lista de jogadores:");
            Console.WriteLine(" ");
            Console.WriteLine("Jogador 1");
            Console.WriteLine(jogador1);
            Console.WriteLine("Jogador 2");
            Console.WriteLine(jogador2);
            int x, y, z, w;
            x = r.Next(6);
            y = r.Next(6);
            z = r.Next(6);
            w = r.Next(6);
            //Controlador jogadas
            for (int i = 1; i <= 1; i++)
            {

                if (x == 0 && z == 0)
                {
                    x = r.Next(6);
                    z = r.Next(6);
                }

                else
                {

                    if (y == 0 && w == 0)
                    {
                        y = r.Next(6);
                        w = r.Next(6);
                    }
                    else
                    {
                        Console.WriteLine("O valor sorteado do primeiro jogador " + jogador1 + " foi " + x + " e " + z + " e do segundo jogador " + jogador2 + " foi " + y + " e " + w);
                    }

                    Console.WriteLine("O valor sorteado do primeiro jogador " + jogador1 + " foi " + x + " e " + z + " e do segundo jogador " + jogador2 + " foi " + y + " e " + w);
                }

            }
            //Calculo dos pontos
            int soma1 = 0, soma2 = 0;

            soma1 = x + z;
            soma2 = y + w;

            Console.WriteLine("A soma dos dados do jogador " + jogador1 + " deu : " + soma1);
            Console.WriteLine("A soma dos dados do jogador " + jogador2 + " deu : " + soma2);

            //Regras
            if (soma1 == 7 || soma1 == 11)
            {
                Console.WriteLine("O jogador " + jogador1 + " passou a vez");
                Console.WriteLine("O jogador " + jogador2 + " é o lançador");
            }
            else
            {
                if (soma2 == 7 || soma2 == 11)
                    Console.WriteLine("O jogador " + jogador2 + " passou a vez");
                Console.WriteLine("O jogador " + jogador1 + " é o lançador");
            }


            if (x > y)
            {
                Console.WriteLine("O jogador " + jogador1 + " é o lançador");

            }
            else
            {
                Console.WriteLine("O jogador " + jogador2 + " é o lançador");
            }
            //crap
            if (soma1 == 2 || soma1 == 3 || soma1 == 12)
            {

                Console.WriteLine("O jogador " + jogador1 + " fez uma jogada ruim");
            }
            else
            {
                if (soma2 == 2 || soma2 == 3 || soma2 == 12)
                {
                    Console.WriteLine("O jogador " + jogador2 + " fez uma jogada ruim");
                }
                else
                {
                    if (soma1 == 2 || soma1 == 3 || soma1 == 12 && soma2 == 2 || soma2 == 3 || soma2 == 12)
                    {
                        Console.WriteLine("Os dois jogadores fizeram uma jogada ruim");
                    }

                }

            }

            //Segunda rodada
            int a = 0, b = 0, c = 0, d = 0;
            int ponto1 = 0, ponto2 = 0;
            int soma3 = 0, soma4 = 0;
            a = r.Next(6);
            b = r.Next(6);
            c = r.Next(6);
            d = r.Next(6);

            for (int i = 1; i <= 1; i++)
            {

                if (a == 0 && b == 0)
                {
                    a = r.Next(6);
                    b = r.Next(6);
                }

                else
                {

                    if (c == 0 && d == 0)
                    {
                        c = r.Next(6);
                        d = r.Next(6);
                    }
                    else
                    {
                        Console.WriteLine("O valor sorteado do primeiro jogador " + jogador1 + " foi " + a + " e " + b + " e do segundo jogador " + jogador2 + " foi " + c + " e " + d);
                    }
                    Console.WriteLine("O valor sorteado do primeiro jogador " + jogador1 + " foi " + a + " e " + b + " e do segundo jogador " + jogador2 + " foi " + c + " e " + d);
                }
            }
            
            soma3 = a + b;
            soma4 = c + d;
            Console.WriteLine("A soma dos dados do jogador " + jogador1 + " deu : " + soma3);
            Console.WriteLine("A soma dos dados do jogador " + jogador2 + " deu : " + soma4);
            soma3 = ponto1;
            soma4 = ponto2;
            if (ponto1 == 7)
            {
                Console.WriteLine("O jogador " + jogador1 + " venceu!");
            }
            else
            {
                if (ponto2== 7)
                {
                    Console.WriteLine("O jogador " + jogador2 + " venceu!");
                }
            }
        }
        //Terceira Rodada

    }
    
}
