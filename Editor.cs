using System.Text;
using Microsoft.VisualBasic;

namespace EditorHTML{
    public static class Editor{
        public static void Show(){

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");

            Start();

        }

        public static void Start(){

            // Quando os textos tem muitas linhas é recomendado usar o StringBuilder.
            var file = new StringBuilder();

            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);


            Console.WriteLine("-----------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Sim, desejo salvar");
            Console.WriteLine("2 - Não, quero apenas visualizar");
            Console.WriteLine("3 - Não, quero descartar o arquivo");
           
            
            var resp = short.Parse(Console.ReadLine());
        
           switch(resp){
                case 1:
                    Salvar(file.ToString());
                break;

                case 2:
                    Viewer.Show(file.ToString());
                break;

                case 3:
                    Show();
                break;

                default:
                    Start();
                break;
           }

        }

        public static void Salvar(string file){

            Console.Clear();

            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var arq = new StreamWriter(path))
            {
                arq.Write(file);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
        }

          public static void Open()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            using (var arq = new StreamReader(path))
            {
                string file = arq.ReadToEnd();
                Console.WriteLine(file);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu.Show();
        }
    }
}