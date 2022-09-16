using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Font
{
    internal class Program
    {
        static bool Proverka(string Stroka)
        {
            foreach (char c in Stroka)
            {
                if (int.TryParse(c.ToString(), out var bar) || c == ' ' || c == '\\' || c == '.')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.SetBufferSize(200, 30);
            Console.Write("Введите ряд цифр от 0 до 9 включая разделители (Пробел,Точка,Запятая): ");
            var Vvod = Console.ReadLine();
            if (!Proverka(Vvod))
            {
                Console.WriteLine("Ввод не корректен!");
            }
            else
            {
                var Razmer = Vvod.Length;
                var SizeX = Razmer * 12;
                var SizeY = 8;
                var x = (Console.WindowWidth / 2) - (SizeX / 2);
                var y = (Console.WindowHeight / 2) - (SizeY / 2);
                foreach (char c in Vvod)
                {
                    switch (c)
                    {
                        case ('0'):
                            Console.SetCursorPosition(x, y);
                            string[] cifra0 =
                              {"  ██████  ",
                               "██      ██",
                               "██    ████",
                               "██  ██  ██",
                               "████    ██",
                               "██      ██",
                               "  ██████  "};
                                for (int i = 0; i < cifra0.GetLength(0); i++)
                                {
                                    Console.SetCursorPosition(x,++y);
                                    Console.WriteLine(cifra0[i]);
                                }
                                x += 12;
                                y = (Console.WindowHeight / 2) - (SizeY / 2);
                                break;
                        case ('1'):
                            Console.SetCursorPosition(x, y);
                            string[] cifra1 =
                              {"    ██    ",
                               "  ████    ",
                               "██  ██    ",
                               "    ██    ",
                               "    ██    ",
                               "    ██    ",
                               "██████████"};
                            for (int i = 0; i < cifra1.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(cifra1[i]);
                            }
                            x += 7;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case ('2'):
                            Console.SetCursorPosition(x, y);
                            string[] cifra2 =
                              {"  ██████  ",
                               "██      ██",
                               "        ██",
                               "  ██████  ",
                               "██        ",
                               "██        ",
                               "██████████"};
                            for (int i = 0; i < cifra2.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(cifra2[i]);
                            }
                            x += 12;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case ('3'):
                            Console.SetCursorPosition(x, y);
                            string[] cifra3 =
                              {"  ██████  ",
                               "██      ██",
                               "        ██",
                               "    ████  ",
                               "        ██",
                               "██      ██",
                               "  ██████  "};
                            for (int i = 0; i < cifra3.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(cifra3[i]);
                            }
                            x += 12;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case ('4'):
                            Console.SetCursorPosition(x, y);
                            string[] cifra4 =
                              {"      ████",
                               "    ██  ██",
                               "  ██    ██",
                               "██      ██",
                               "██████████",
                               "        ██",
                               "        ██"};
                            for (int i = 0; i < cifra4.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(cifra4[i]);
                            }
                            x += 12;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case ('5'):
                            Console.SetCursorPosition(x, y);
                            string[] cifra5 =
                              {"██████████",
                               "██        ",
                               "████████  ",
                               "██      ██",
                               "        ██",
                               "██      ██",
                               "  ██████  "};
                            for (int i = 0; i < cifra5.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(cifra5[i]);
                            }
                            x += 12;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case ('6'):
                            Console.SetCursorPosition(x, y);
                            string[] cifra6 =
                              {"  ██████  ",
                               "██      ██",
                               "██        ",
                               "████████  ",
                               "██      ██",
                               "██      ██",
                               "  ██████  "};
                            for (int i = 0; i < cifra6.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(cifra6[i]);
                            }
                            x += 12;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case ('7'):
                            Console.SetCursorPosition(x, y);
                            string[] cifra7 =
                              {"██████████",
                               "        ██",
                               "        ██",
                               "      ██  ",
                               "    ██    ",
                               "    ██    ",
                               "    ██    "};
                            for (int i = 0; i < cifra7.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(cifra7[i]);
                            }
                            x += 12;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case ('8'):
                            Console.SetCursorPosition(x, y);
                            string[] cifra8 =
                              {"  ██████  ",
                               "██      ██",
                               "██      ██",
                               "  ██████  ",
                               "██      ██",
                               "██      ██",
                               "  ██████  "};
                            for (int i = 0; i < cifra8.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(cifra8[i]);
                            }
                            x += 12;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case ('9'):
                            Console.SetCursorPosition(x, y);
                            string[] cifra9 =
                              {"  ██████  ",
                               "██      ██",
                               "██      ██",
                               "  ████████",
                               "        ██",
                               "██      ██",
                               "  ██████  "};
                            for (int i = 0; i < cifra9.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(cifra9[i]);
                            }
                            x += 12;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case (' '):
                            Console.SetCursorPosition(x, y);
                            string[] probel =
                              {"          ",
                               "          ",
                               "          ",
                               "          ",
                               "          ",
                               "          ",
                               "          "};
                            for (int i = 0; i < probel.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(probel[i]);
                            }
                            x += 3;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case (','):
                            Console.SetCursorPosition(x, y);
                            string[] zapyataya =
                              {"          ",
                               "          ",
                               "          ",
                               "          ",
                               "          ",
                               "    ████  ",
                               "      ██  ",
                               "      ██  ",
                               "    ██    "};
                            for (int i = 0; i < zapyataya.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(zapyataya[i]);
                            }
                            x += 12;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                        case ('.'):
                            Console.SetCursorPosition(x, y);
                            string[] tochka =
                              {"          ",
                               "          ",
                               "          ",
                               "          ",
                               "          ",
                               "          ",
                               "    ██    "};
                            for (int i = 0; i < tochka.GetLength(0); i++)
                            {
                                Console.SetCursorPosition(x, ++y);
                                Console.WriteLine(tochka[i]);
                            }
                            x += 12;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                            break;
                    }
                }
                Console.ReadKey();
            }
            Console.WriteLine("\n\n\n\n\n\n\n\n");
        }
    }
}