using System;

namespace JogoMortal
{
    class Program:Pisos
    {
        static void Main(string[] args)
        {
            Pisos P = new Pisos();
            Console.WriteLine("Escolha um lado?");
            Console.WriteLine("ESQUERDA = 1");
            Console.WriteLine("DIREITA = 2");
            Console.WriteLine("1 ou 2?");
            P.piso1 = Console.ReadLine();
            if (P.piso1 == "1")
            {
                Console.WriteLine("Você Perdeu");
            }
            else
            {
                if(P.piso1 == "2")
                {
                    Console.WriteLine("Passou");
                    Console.WriteLine("Escolha novamente?");
                    P.piso2 = Console.ReadLine();
                    if (P.piso2 == "2")
                    {
                        Console.WriteLine("Você Perdeu");
                    }
                    else
                    {
                        if (P.piso2 == "1")
                        {
                            Console.WriteLine("Passou");
                            Console.WriteLine("Escolha novamente?");
                            P.piso3 = Console.ReadLine();
                            if (P.piso3 == "2")
                            {
                                Console.WriteLine("Você Perdeu");
                            }
                            else
                            {
                                if (P.piso3 == "1")
                                {
                                    Console.WriteLine("Parabens");
                                    Console.WriteLine("Voce Ganhou");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
