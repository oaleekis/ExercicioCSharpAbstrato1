using ExercicioCSharpAbstrato1.Entities;
using ExercicioCSharpAbstrato1.Entities.Enums;
using System.Globalization;

namespace ExercicioCSharpAbstrato1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data: ");
                Console.Write("Rectangle or Circle (r, c)? ");
                char form = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());


                if (form == 'r' | form == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shape shape = new Rectangle(color, width, height);
                    list.Add(shape);

                }
                else if (form == 'c' | form == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shape shape = new Circle(color, radius);
                    list.Add(shape);
                }
            }
            Console.WriteLine("SHAPE AREAS: ");
            foreach (var item in list)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}