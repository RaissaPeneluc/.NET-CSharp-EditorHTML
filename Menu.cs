namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {

            Console.Clear();

            // Troca a cor de fundo do console.
            Console.BackgroundColor = ConsoleColor.Magenta;

            // Troca a cor da letra do console.
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }

        public static void DrawScreen()
        {

            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {

                Console.Write("|");

                for (int i = 0; i <= 38; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");

        }

        public static void WriteOptions()
        {

            // SetCursorPosition => Usado para escrever algo em uma posição específica da tela, ele pede a posição da tela por colunas e linhas.
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");


        }

        // Função que manipula o clique de um botão
        public static void HandleMenuOption(short option)
        {

            switch (option)
            {
                case 1:
                    Editor.Show();
                    break;

                case 2:
                    Editor.Open();
                    break;

                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                default:
                    Show();
                    break;
            }

        }
    }
}
