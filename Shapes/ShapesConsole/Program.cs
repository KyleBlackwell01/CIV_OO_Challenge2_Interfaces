using System;
using Shapes;

namespace ShapesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq1;
            Rectangle rec1;
            Equilateral eq1;
            RightAngle ra1;
            Circle cir1;
            Input t = new Input();

            Console.WriteLine("Hello World!");

            Console.WriteLine("A: Square, B: Rectangle, C: Equilateral, D: Right-Angled, E: Circle");

            string input = Console.ReadLine();

            int count = 0;

            string tests;

            while (count == 0)
            {
                if(input == "A" || input == "a")
                {
                    Console.WriteLine("Please enter required values");
                    Console.WriteLine("Please enter a colour");
                    tests = Console.ReadLine();
                    Console.WriteLine("Side 1: ");
                    try
                    {
                        t.s1 = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        if (ex is FormatException || ex is InvalidInput)
                        {
                            Console.WriteLine("Test: " + ex.Message);
                        }
                    }

                    sq1 = new Square(tests, t.s1);

                    Console.WriteLine(sq1.GetArea(t.s1));
                    Console.WriteLine(sq1.GetPerimeter(t.s1));

                    Console.WriteLine("Do you want to finish? Y/N");
                    input = Console.ReadLine();
                    if (input == "Y" || input == "y")
                    {
                        count = count + 1;
                    }
                    else if (input == "N" || input == "n")
                    {
                        Console.WriteLine("Continuing...");
                    }
                    else
                    {
                        Console.WriteLine("Invalid response, continuing by default...");
                    }

                }
                else if (input == "B" || input == "b")
                {
                    Console.WriteLine("Please enter required values");
                    Console.WriteLine("Please enter a colour");
                    tests = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Side 1: ");
                        t.s1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Side 2: ");
                        t.s2 = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        if (ex is FormatException || ex is InvalidInput)
                        {
                            Console.WriteLine("Test: " + ex.Message);
                        }
                    }

                    rec1 = new Rectangle(tests, t.s1, t.s2);

                    Console.WriteLine(rec1.GetArea(t.s1));
                    Console.WriteLine(rec1.GetPerimeter(t.s1));

                    Console.WriteLine("Do you want to finish? Y/N");
                    input = Console.ReadLine();
                    if (input == "Y" || input == "y")
                    {
                        count = count + 1;
                    }
                    else if (input == "N" || input == "n")
                    {
                        Console.WriteLine("Continuing...");
                    }
                    else
                    {
                        Console.WriteLine("Invalid response, continuing by default...");
                    }


                }
                else if (input == "C" || input == "c")
                {
                    Console.WriteLine("Please enter required values");
                    Console.WriteLine("Please enter a colour");
                    tests = Console.ReadLine();
                    Console.WriteLine("Side 1: ");
                    try
                    {
                        t.s1 = double.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        if (ex is FormatException || ex is InvalidInput)
                        {
                            Console.WriteLine("Test: " + ex.Message);
                        }
                    }

                    eq1 = new Equilateral(tests, t.s1);

                    Console.WriteLine(eq1.GetArea(t.s1));

                    Console.WriteLine("Do you want to finish? Y/N");
                    input = Console.ReadLine();
                    if (input == "Y" || input == "y")
                    {
                        count = count + 1;
                    }
                    else if (input == "N" || input == "n")
                    {
                        Console.WriteLine("Continuing...");
                    }
                    else
                    {
                        Console.WriteLine("Invalid response, continuing by default...");
                    }
                }
                else if (input == "D" || input == "d")
                {
                    Console.WriteLine("Please enter required values");
                    Console.WriteLine("Please enter a colour");
                    tests = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Side 1: ");
                        t.s1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Side 2: ");
                        t.s1 = double.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        if (ex is FormatException || ex is InvalidInput)
                        {
                            Console.WriteLine("Test: " + ex.Message);
                        }
                    }

                    ra1 = new RightAngle(tests, t.s1, t.s1);

                    ra1.SetHypotenuse(t.s1, t.s1);

                    Console.WriteLine(ra1.GetArea(t.s1));
                    Console.WriteLine(ra1.GetPerimeter(t.s1));

                    Console.WriteLine("Do you want to finish? Y/N");
                    input = Console.ReadLine();
                    if(input == "Y" || input == "y")
                    {
                        count = count + 1;
                    }
                    else if (input == "N" || input == "n")
                    {
                        Console.WriteLine("Continuing...");
                    }
                    else
                    {
                        Console.WriteLine("Invalid response, continuing by default...");
                    }

                }
                else if (input == "E" || input == "e")
                {
                    Console.WriteLine("Please enter required values");
                    Console.WriteLine("Please enter a colour");
                    tests = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Side 1: ");
                        t.s1 = double.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        if (ex is FormatException || ex is InvalidInput)
                        {
                            Console.WriteLine("Test: " + ex.Message);
                        }
                    }

                    cir1 = new Circle(tests, t.s1);
                    Console.WriteLine(cir1.GetArea(t.s1));
                    Console.WriteLine(cir1.GetPerimeter(t.s1));

                    Console.WriteLine("Do you want to finish? Y/N");
                    input = Console.ReadLine();
                    if (input == "Y" || input == "y")
                    {
                        count = count + 1;
                    }
                    else if (input == "N" || input == "n")
                    {
                        Console.WriteLine("Continuing...");
                    }
                    else
                    {
                        Console.WriteLine("Invalid response, continuing by default...");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option, press any key to exit.");
                    Console.ReadKey(true);
                    count = count+ 1;
                }
            }


            Console.WriteLine("Exiting...");
            Console.ReadKey(true);
        }
    }

    public class InvalidInput : Exception
    {
        public InvalidInput(string message) : base(message)
        {

        }
    }

    public class Input
    {
        public double s1 = 0;
        public double s2 = 0;
        public void ShowInput()
        {
            if (s1 <= 0 || s2 <= 0)
            {
                throw (new InvalidInput("Number less than or equal to 0 detected."));
            }


        }

    }
}