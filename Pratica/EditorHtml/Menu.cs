using System;

namespace EditorHtml {
    public static class Menu {
        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreeen();

            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }
        // Desenhar a tela
        public static void DrawScreeen() {

            
            Console.Write("+");
            for (int i = 0; i <= 30; i++) {
                Console.Write("-");
            }
            
            Console.Write("-");
            Console.Write("\n");

            // l = lines
            for(int l = 0; l <= 10; l++)  {
                Console.Write("|");
                for (int i = 0; i <= 30; i++) {
                    Console.Write(" ");
                }
                    
                Console.Write("|");
                Console.Write("\n");
        
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++) {
                Console.Write("-");
            }
            
            Console.Write("-");
            Console.Write("\n");
        }
        // Mostrar opções na tela
        public static void WriteOptions() {
            Console.SetCursorPosition(3,2);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção:_");
        }
        // Handle = Manipular Opções
        public static void HandleMenuOption(short option) {
            switch(option) {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Console.WriteLine("View");
                    break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default:
                    Show();
                    break;
            }
        }
    }
}