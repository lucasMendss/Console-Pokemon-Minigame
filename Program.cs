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
            Console.Write("Charmander (tipo Fogo)");
            Console.ResetColor();
            Console.Write(", ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Squirtle (tipo Água) ");
            Console.ResetColor();
            Console.Write("e ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Pikachu (tipo Elétrico) ");
            Console.ResetColor();
            Console.WriteLine("para batalhar contra ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Glaceon (tipo Gelo)");
            Console.ResetColor();
            Console.Write(", ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Flareon (tipo Fogo) ");
            Console.ResetColor();
            Console.Write("e ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Pidgey (tipo Voador)");
            Console.ResetColor();
            Console.WriteLine(". Na batalha, você deve usar um pokémon que possui para cada pokémon inimigo.");
            Console.WriteLine(" ");

            //Batalhas 
            Glaceon:
            Console.Write("A primeira batalha é contra ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Glaceon");
            Console.ResetColor();
            Console.Write(". Você escolhe qual dos seus três pokémons? ");
            Console.WriteLine("(Digite apenas o nome sem o tipo do lado).");

            string escolhido1 = Console.ReadLine();

            switch (escolhido1)
            {
                case "Charmander":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Seu Charmander derrotou Glaceon pois fogo tem vantagem contra gelo!");
                Console.ResetColor();
                goto Flareon;

                case "Squirtle":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Glaceon derrotou seu Squirtle pois gelo tem vantagem contra água... Tente de novo!");
                Console.ResetColor();
                goto Glaceon;

                case "Pikachu":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seu Pikachu não tem vantagens contra Glaceon... Tente de novo!");
                Console.ResetColor();
                goto Glaceon;

                default:
                Console.WriteLine("Não entendi!");
                break;
            }
            goto Glaceon;


            Flareon: 
            Console.Write("A segunda batalha é contra ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Flareon");
            Console.ResetColor();
            Console.Write(". Você escolhe qual dos seus três pokémons? ");
            Console.WriteLine("(Digite apenas o nome sem o tipo do lado).");

            string escolhido2 = Console.ReadLine();

            switch (escolhido2)
            {
                case "Charmander":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seu Charmander já batalhou, ele está exausto! Escolha outro.");
                Console.ResetColor();
                goto Flareon;

                case "Squirtle":
                 Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Seu squirtle derrotou Flareon pois água tem vantagem contra fogo!");
                Console.ResetColor();
                goto Pidgey;

                case "Pikachu":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seu Pikachu não tem vantagem contra Flareon");
                Console.ResetColor();
                goto Flareon;

                default:
                Console.WriteLine("Não entendi!");
                break;
            }
            goto Pidgey;

            Pidgey:
            Console.Write("A última batalha é contra ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Pidgey");
            Console.ResetColor();
            Console.Write(". Você escolhe qual dos seus três pokémons? ");
            Console.WriteLine("(Digite apenas o nome sem o tipo do lado).");

            string escolhido3 = Console.ReadLine();

            switch(escolhido3)
            {
                case "Charmander":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seu Charmander já batalhou, ele está exausto! Escolha outro.");
                Console.ResetColor();
                goto Pidgey;

                case "Squirtle":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Seu Squirtle já batalhou, ele está exausto! Escolha outro.");
                Console.ResetColor();
                goto Pidgey;

                case "Pikachu":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Seu Pikachu derrotou Pidgey pois o tipo Elétrico tem vantagem contra voador!");
                Console.ResetColor();
                goto Fim;

                default:
                Console.WriteLine("Não entendi!");
                break;
            }
            goto Fim;


            Fim:
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Parabéns! Você derrotou todos os pokémons inimigos!");
            return;
        }
    }
}
