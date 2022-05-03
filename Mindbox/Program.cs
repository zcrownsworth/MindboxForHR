namespace Library
{

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.WriteLine(triangle.GetTriangleArea(15, 12, 14)); // Получение площади по 3 сторонам
            Console.WriteLine(triangle.ChekTriangle(3,4,5));  // Проверка является ли треугольник прямоугольным

            Circle circle = new Circle();
            Console.WriteLine(circle.GetCircleArea(58)); // Получение площади круга по радиусу

        }

    }
}

