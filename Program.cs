using System;

namespace jogopokemons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write("|Escolha e batalha de pokémons| by Lucas Mendes");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.Write("Você é um treinador pokémon e ");
            Console.Write("possui o ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("CHARMANDER (tipo Fogo)");
            Console.ResetColor();
            Console.Write(", ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("SQUIRTLE (tipo Água) ");
            Console.ResetColor();
            Console.Write("e ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("PIKACHU (tipo Elétrico) ");
            Console.ResetColor();
            Console.WriteLine("para batalhar contra ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("GLACEON (tipo Gelo)");
            Console.ResetColor();
            Console.Write(", ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("FLAREON (tipo Fogo) ");
            Console.ResetColor();
            Console.Write("e ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("PIDGEY (tipo Voador)");
            Console.ResetColor();
            Console.WriteLine(". Na batalha, você deve usar um pokémon que possui para cada pokémon inimigo.");
            Console.WriteLine(" ");

        //Batalhas 
        GLACEON:
            Console.Write("A primeira batalha é contra ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("GLACEON");
            Console.ResetColor();
            Console.Write(". Você escolhe qual dos seus três pokémons? ");
            Console.WriteLine("(Digite apenas o nome sem o tipo do lado).");

            string escolhido1 = Console.ReadLine().ToUpper();

            switch (escolhido1)
            {
                case "CHARMANDER":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seu Charmander derrotou Glaceon pois fogo tem vantagem contra gelo!");
                    Console.ResetColor();
                    goto FLAREON;

                case "SQUIRTLE":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Glaceon derrotou seu Squirtle pois gelo tem vantagem contra água... Tente de novo!");
                    Console.ResetColor();
                    goto GLACEON;

                case "PIKACHU":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seu Pikachu não tem vantagens contra Glaceon... Tente de novo!");
                    Console.ResetColor();
                    goto GLACEON;

                default:
                    Console.WriteLine("Não entendi!");
                    break;
            }
            goto GLACEON;


        FLAREON:
            Console.Write("A segunda batalha é contra ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Flareon");
            Console.ResetColor();
            Console.Write(". Você escolhe qual dos seus três pokémons? ");
            Console.WriteLine("(Digite apenas o nome sem o tipo do lado).");

            string escolhido2 = Console.ReadLine().ToUpper();

            switch (escolhido2)
            {
                case "CHARMANDER":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seu Charmander já batalhou, ele está exausto! Escolha outro.");
                    Console.ResetColor();
                    goto FLAREON;

                case "SQUIRTLE":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seu squirtle derrotou Flareon pois água tem vantagem contra fogo!");
                    Console.ResetColor();
                    goto PIDGEY;

                case "PIKACHU":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seu Pikachu não tem vantagem contra Flareon");
                    Console.ResetColor();
                    goto FLAREON;

                default:
                    Console.WriteLine("Não entendi!");
                    break;
            }
            goto PIDGEY;

        PIDGEY:
            Console.Write("A última batalha é contra ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("PIDGEY");
            Console.ResetColor();
            Console.Write(". Você escolhe qual dos seus três pokémons? ");
            Console.WriteLine("(Digite apenas o nome sem o tipo do lado).");

            string escolhido3 = Console.ReadLine().ToUpper();

            switch (escolhido3)
            {
                case "CHARMANDER":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seu Charmander já batalhou, ele está exausto! Escolha outro.");
                    Console.ResetColor();
                    goto PIDGEY;

                case "SQUIRTLE":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Seu Squirtle já batalhou, ele está exausto! Escolha outro.");
                    Console.ResetColor();
                    goto PIDGEY;

                case "PIKACHU":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Seu Pikachu derrotou Pidgey pois o tipo Elétrico tem vantagem contra voador!");
                    Console.ResetColor();
                    goto FIM;

                default:
                    Console.WriteLine("Não entendi!");
                    break;
            }
            goto FIM;

        FIM:
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Parabéns! Você derrotou todos os pokémons inimigos!");
            return;
        }
    }
}
