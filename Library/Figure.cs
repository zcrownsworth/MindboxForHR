namespace Library
{
    public abstract class Figure
    {
        public double Area { get; set; }


        /// <summary>
        /// Получение площади круга по радиусу
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns>Радиус круга</returns>
        public double GetCircleArea(double radius)
        {
            Area = Math.PI *Math.Pow(radius, 2);
            return Area;
        }
        /// <summary>
        /// Получение площади треугольника по трем сторонам
        /// </summary>
        /// <param name="size1">1 сторона</param>
        /// <param name="size2">2 сторона</param>
        /// <param name="size3">3 сторона</param>
        /// <returns>Площадь треугольника</returns>
        public double GetTriangleArea(double size1,double size2,double size3)
        {
           double p = (size1 + size2+size3) / 2; // p = halfPerimeter

            Area = Math.Sqrt(p * (p - size1) * (p - size2) * (p - size3));

            return Area;
        }
    }
}