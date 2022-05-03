using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Triangle : Figure
    {
        public Triangle()
        {
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        /// <param name="size1">1 сторона </param>
        /// <param name="size2">2 сторона</param>
        /// <param name="size3">3 сторона</param>
        /// <returns></returns>
        public string ChekTriangle(double size1, double size2, double size3)
        {
            if ((size1* size1) + (size2 * size2) == (size3* size3)) //a * a + b * b == c * c
            {
                return "right triangle";
            }
            else
            {
                return "triangle is not right";
            }
        }

    }
}
