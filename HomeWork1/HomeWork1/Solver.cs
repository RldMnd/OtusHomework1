using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Solver
    {
        public int Test()
        {
            return 1;
        }

        public double[] Solve(double a, double b, double c)
        {
            var discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                //Отрицательеый дискриминат - уравнение не имеет действительных корней
                return new double[0];
            }
            var res = new Double[2];
            res[0] = (-b + Math.Sqrt(discriminant)) / 2 / a;
            res[1] = (-b - Math.Sqrt(discriminant)) / 2 / a;
            return res;
        }
    }
}
