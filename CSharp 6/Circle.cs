using static System.Math;

namespace CSharp_6
{
    public class Circle
    {
        public double CalculatePerimeter(int radius)
        {
            // using static, static method doesn't need to be qualified
            return 2 * PI * radius;
        }
    }
}