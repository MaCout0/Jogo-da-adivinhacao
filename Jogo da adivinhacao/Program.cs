namespace Jogo_da_adivinhacao
{
    internal class Program
    {
        static int pontuacao = 1000;
        static void Main(string[] args)
        {
            Random afonso = new Random();
            int partida = afonso.Next(0, 20);
            int opcao, userescolha;


            while (true)
            {
                int i = 0;
                Console.Clear();
                Console.WriteLine("Vamos jogar?!");
                Console.WriteLine("Será gerado um número aleatório de 1 a 20 e você deve tentar acertar!");
                Console.WriteLine("Selecione uma das seguintes opções de nível de dificuldade: \n1 - Fácil \n2 - Médio \n3 - Difícil \n4 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 4)
                {
                    break;
                }

                Console.Clear();
                Console.WriteLine("Digite um valor inteiro entre 1 e 20");
                userescolha = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        while(i < 15)
                        {
                            if (userescolha == partida)
                            {
                                Console.Clear();
                                Console.WriteLine("Parabéns você acertou!");
                                Console.WriteLine($"Sua pontuação foi de : {pontuacao}");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                verifica(partida, ref i, ref userescolha);
                            }
                        }
                        if (i >= 15)
                        {
                            Console.Clear();
                            Console.WriteLine("GAME OVER!!");
                            Console.ReadLine();
                        }
                        break;

                    case 2:
                        while(i < 10)
                        {
                            if (userescolha == partida)
                            {
                                Console.Clear();
                                Console.WriteLine("Parabéns você acertou!");
                                Console.WriteLine($"Sua pontuação foi de : {pontuacao}");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                verifica(partida, ref i, ref userescolha);
                            }
                        }
                        if (i >= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("GAME OVER!!");
                            Console.ReadLine();
                        }
                        break;  

                    case 3:
                        while(i < 5)
                        {
                            if (userescolha == partida)
                            {
                                Console.Clear();
                                Console.WriteLine("Parabéns você acertou!");
                                Console.WriteLine($"Sua pontuação foi de : {pontuacao}");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                verifica(partida, ref i, ref userescolha);
                            }
                        }
                        if (i >= 5)
                        {
                            Console.Clear();
                            Console.WriteLine("GAME OVER!!");
                            Console.ReadLine();
                        }
                    break;  

                    
                }
            }
        }

        static void verifica(int partida, ref int i, ref int userescolha)
        {
            i++;
            if (userescolha < partida)
            {
                Console.Clear();
                Console.WriteLine("Resposta errada!!");
                Console.WriteLine("O numero digitado é menor que o valor escolhido!");
            }
            if (userescolha > partida)
            {
                Console.Clear();
                Console.WriteLine("Resposta errada!!");
                Console.WriteLine("O numero digitado é maior que o valor escolhido!");
            }
            pontuacao -= Math.Abs((userescolha-partida)/2);
            Console.WriteLine("Tente novamente: ");
            userescolha = Convert.ToInt32(Console.ReadLine());

        }
    }
}
