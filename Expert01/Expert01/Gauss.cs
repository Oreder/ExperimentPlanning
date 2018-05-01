using System;

namespace Expert01
{
    class Gauss
    {
        /// <summary>
        /// Applying The Marsaglia polar method.
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        public static double NextGaussian(Random random)
        {
            double v1, v2, s;
            do
            {
                v1 = 2.0 * random.NextDouble() - 1.0;
                v2 = 2.0 * random.NextDouble() - 1.0;
                s = v1 * v1 + v2 * v2;
            } while (s >= 1.0 || s == 0);

            s = Math.Sqrt((-2.0 * Math.Log(s)) / s);

            return v1 * s;
        }

        /// <summary>
        /// Mapping to arbitrary Gaussian curves. The up-algorithm provides 
        /// a way to sample from \mathcal{N} \left(0,1 \right). We can transform 
        /// that into any arbitrary \mathcal{N} \left(\mu,\sigma^2 \right).
        /// </summary>
        /// <param name="mean"></param>
        /// <param name="standard_deviation"></param>
        /// <returns></returns>
        public static double NextGaussian(double mean, double standard_deviation)
        {
            return mean + NextGaussian(new Random()) * standard_deviation;
        }

        /// <summary>
        /// Clamping a Gaussian variable between a min and a max can have quite 
        /// catastrophic results.
        /// </summary>
        /// <param name="mean"></param>
        /// <param name="standard_deviation"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static double NextGaussian(double mean, double standard_deviation, double min, double max)
        {
            double x;
            do
            {
                x = NextGaussian(mean, standard_deviation);
            } while (x < min || x > max);
            return x;
        }
    }
}
