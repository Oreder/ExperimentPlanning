using System;

namespace Expert01
{
    class DistributionsGenerator
    {
        Random random;
        double a;
        double b;
        double sigma;
        double m;

        public DistributionsGenerator(Random nRandom, double nA, double nB, double nSigma, double nM)
        {
            random = nRandom;
            a = nA;
            b = nB;
            sigma = nSigma;
            m = nM;
        }

        public double NextNormal()
        {
            double result = 0;
            int k = 12;
            for (int i = 0; i < k; i++)
            {
                result += random.NextDouble();
            }
            result = (result - 6) * sigma + m;
            return result;
        }

        public double NextEven()
        {
            double r = random.NextDouble();
            double result = a + (b - a) * r;
            return result;
        }
    }
}
