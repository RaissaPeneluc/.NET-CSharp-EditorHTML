using System.Text.RegularExpressions;

namespace EditorHTML
{
    public class Viewer
    {
        public static void Show(string text)
        {

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();

            // Após digitar o texto, ele vai para o visualizador, após terminar, ele volta para o menu.
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------------");
            Replace(text);
            Console.WriteLine("-----------------");
            Console.ReadKey();
            Menu.Show();

        }

        public static void Replace(string text)
        {

            //  Regex => Expressão regular, uma string que substitui uma outra string de formas diferentes.
            // @ => Tira o erro do escape \
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");

            // Pega todas as palvras do texto.
            var words = text.Split(' ');

            // Percorrendo todas as palavras.
            for (var i = 0; i < words.Length; i++)
            {
                // Vendo se a palavra está entre <stron> <\strong>.
                // words[i] => Pegando um índice de um array de palavras.
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    // Escrever essa palavra sem o <strong> <\strong>.
                    Console.Write(
                        words[i].Substring(

                            // Pegando o primeiro índice, lembrando que começa a partir do 0.
                            words[i].IndexOf('>') + 1,

                            // Pegando o último índice
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                        )
                    );

                    Console.Write(" ");

                }else{
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }


        }


    }
}