using Laboratorio_7_OOP_201902.Cards;
using Laboratorio_7_OOP_201902.Static;
using System;
using System.Collections.Generic;
using System.IO;

namespace Laboratorio_7_OOP_201902
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Game.txt";
            if (Directory.Exists(path) == true)
            {
                Console.WriteLine("¿Desea cargar la partida anterior? /n 1 = Si /n 2 = No");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        game.LoadData(game);
                        break;
                case "2":
                        break;
                }

            }
            game.Play();
        }            
    }
}
