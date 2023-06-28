using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

   

        static void JogarCampoMinado(CampoMinado campoMinado)
        {
            while (campoMinado.JogoStatus == 0)
            {
                // Lógica para jogar o Campo Minado de forma autônoma
                bool jogadaRealizada = false;

                for (int linha = 0; linha < 9; linha++)
                {
                    for (int coluna = 0; coluna < 9; coluna++)
                    {
                        if (campoMinado.Jogo[linha, coluna] == "-")
                        {
                            campoMinado.Abrir(linha + 1, coluna + 1);
                            jogadaRealizada = true;
                            break;
                        }
                        }

                    if (jogadaRealizada)
                    {
                        break;
                    }
                }
            }

            if (campoMinado.JogoStatus == 1)
            {
                Console.WriteLine("Parabéns! Você venceu o Campo Minado!");
            }
            else if (campoMinado.JogoStatus == 2)
            {
                Console.WriteLine("Game Over! Você encontrou uma mina terrestre!");
            }
        }
    }
}

        }
    }
}
