using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace EditorHTML{
   
        public static class Menu{
            public static void Show(){
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
               Draw();
               writeOpt();
               var opt = short.Parse(Console.ReadLine());
               HandleMenu(opt);
            }
            public static void Draw(){
          linhaH();
          linhaV();
          linhaH();

        }
        static void linhaH(){
                Console.Write("+");
                for(int i = 0;i<=30;i++){
                Console.Write("-");}

                Console.Write("+");
                Console.Write("\n");
                }
                static void linhaV(){
                for(int lines = 0;lines<=10;lines++){
                
                Console.Write("|");
                for(int i = 0; i <= 30; i++)
                Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
                

                
            }}
            public static void writeOpt(){
                Console.SetCursorPosition(10,2);
                Console.WriteLine("Editor HTML");
                Console.SetCursorPosition(3,3);
                Console.WriteLine("====================");
                Console.SetCursorPosition(3,4);
                Console.WriteLine("Escolha uma opção abaixo: ");
                Console.SetCursorPosition(3,6);
                Console.WriteLine(" 1 - Novo arquivo");
                Console.SetCursorPosition(3,7);
                Console.WriteLine(" 2 - Abrir");
                Console.SetCursorPosition(3,9);
                Console.WriteLine(" 0 - Sair");
                Console.SetCursorPosition(3,10);
                Console.WriteLine(" Opção: ");
                
                
            }
            public static void HandleMenu(short opt){
                switch(opt){
                    case 1: Editor.Show();break;
                    case 2: Console.WriteLine("New");break;
                    case 0:{
                        Console.Clear();
                        Environment.Exit(0);
                        break;}

                        default: Show(); break;
                }

            }
        }}
    
