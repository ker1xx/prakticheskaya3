namespace prac3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopp = 0;
            do
            {
                Console.WriteLine(" Всем привет это пианино");
                Console.WriteLine("По умолчанию стоит 2 октава");
                Console.WriteLine("Чтобы сменить октаву, нажмите 'L");
                Console.WriteLine("Чтобы играть, нажмите любую клавишу");
                ConsoleKeyInfo key = Console.ReadKey();
                int[] massiv = new int[12]
                {65,69,73,78,82,87,93,98,104,110,117,124};
                if (key.Key == ConsoleKey.L)
                    Oktavi(massiv);
                int stop = 1;
                Console.WriteLine("Чтобы выйти в меню, нажмите 'Escape'");
                Console.WriteLine("Сейчас вы можете играть на клавиатуре как на пианино. Чтобы это сделать, просто нажимайте на клавиатуру");
                do
                {
                    Console.Clear();
                    Console.WriteLine("Чтобы выйти в меню, нажмите 'Escape'");
                    ConsoleKey nota = Console.ReadKey().Key;
                    switch (nota)
                    {
                        case (ConsoleKey.A):
                            Console.Beep(massiv[0], 250);
                            break;
                        case (ConsoleKey.Q):
                            Console.Beep(massiv[1], 250);
                            break;
                        case (ConsoleKey.S):
                            Console.Beep(massiv[2], 250);
                            break;
                        case (ConsoleKey.W):
                            Console.Beep(massiv[3], 250);
                            break;
                        case (ConsoleKey.D):
                            Console.Beep(massiv[4], 250);
                            break;
                        case (ConsoleKey.F):
                            Console.Beep(massiv[5], 250);
                            break;
                        case (ConsoleKey.R):
                            Console.Beep(massiv[6], 250);
                            break;
                        case (ConsoleKey.G):
                            Console.Beep(massiv[7], 250);
                            break;
                        case (ConsoleKey.T):
                            Console.Beep(massiv[8], 250);
                            break;
                        case (ConsoleKey.H):
                            Console.Beep(massiv[9], 250);
                            break;
                        case (ConsoleKey.Y):
                            Console.Beep(massiv[10], 250);
                            break;
                        case (ConsoleKey.J):
                            Console.Beep(massiv[11], 250);
                            break;
                        case (ConsoleKey.Escape):
                            stop = 0;
                            Console.Clear();
                            break;

                    }
                } while (stop != 0);


            } while (stopp != 1);
        }


        static int Oktavi(int[] massiv)
        {
            Console.Clear();
            Console.WriteLine("Выбор октавы");
            Console.WriteLine("Чтобы выбрать октаву, нажимте F1, F2, F3...");
            Console.WriteLine("В программе реализованы 7 октав (со 2 по 8)");
            ConsoleKeyInfo readoktava = Console.ReadKey();
            switch (readoktava.Key)
            {
                case ConsoleKey.F1:
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            massiv[i] *= 1;
                        }
                        Console.WriteLine("Вторая октава");
                        break;
                    }
                case ConsoleKey.F2:
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            massiv[i] *= 2;
                        }
                        Console.WriteLine("Третья октава");
                        break;
                    }
                case ConsoleKey.F3:
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            massiv[i] *= 4;
                        }
                        Console.WriteLine("Четвертая октава");
                        break;
                    }
                case ConsoleKey.F4:
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            massiv[i] *= 8;
                        }
                        Console.WriteLine("Пятая октава");
                        break;
                    }
                case ConsoleKey.F5:
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            massiv[i] *= 16;
                        }
                        Console.WriteLine("Шестая октава");
                        break;
                    }
                case ConsoleKey.F6:
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            massiv[i] *= 32;
                        }
                        Console.WriteLine("Седьмая октава");
                        break;
                    }
                case ConsoleKey.F7:
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            massiv[i] *= 64;
                        }
                        Console.WriteLine("Восьмая октава");
                        break;
                    }
            }
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("Вы будете перемещены в пианино через: " + i);
                System.Threading.Thread.Sleep(550);
            }
            Console.Clear();
            Console.WriteLine("Чтобы вернуться, нажмите 'Escape'");
                    return massiv[0];
                    return massiv[1];
                    return massiv[2];
                    return massiv[3];
                    return massiv[4];
                    return massiv[5];
                    return massiv[6];
                    return massiv[7];
                    return massiv[8];
                    return massiv[9];
                    return massiv[10];
                    return massiv[11];

            }
        }
    }
