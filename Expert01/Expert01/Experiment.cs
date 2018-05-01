using System;
using System.Collections.Generic;

namespace Expert01
{
    class Experiment
    {
        int TasksCount { get; set; }

        // normal 
        public double Lambda { get; set; }
        public double Sigma { get; set; }

        // even
        public double Mu { get; set; }
        public double Delta { get; set; }

        Random random;

        public Experiment(int nTasksCount, double nLambda, double nSigma, double nMu, double nDelta)
        {
            TasksCount = nTasksCount;
            Lambda = nLambda;
            Sigma = nSigma;
            Mu = nMu;
            Delta = nDelta;
            random = new Random();
        }

        public double GetResult()
        {
            int NowTasks = 0;
            double LastCome = 0;
            double LastRelease = 0;
            double Start = 0;
            int i = 0;

            DistributionsGenerator Generator =
                new DistributionsGenerator(random, Mu - Delta, Mu + Delta, Sigma, Lambda);
            Queue<double> Buffer = new Queue<double>();

            while (NowTasks < TasksCount)
            {
                if (Buffer.Count == 0)
                {
                    LastCome = LastCome + Generator.NextEven();
                    Buffer.Enqueue(LastCome);
                    i++;
                }

                Start = Buffer.Dequeue();
                if (Start < LastRelease)
                    Start = LastRelease;

                LastRelease = Start + Generator.NextNormal();
                while (LastCome < LastRelease && i < TasksCount)
                {
                    LastCome = LastCome + Generator.NextEven();
                    Buffer.Enqueue(LastCome);
                    i++;
                }
                NowTasks++;
            }
            return LastRelease;
        }
    }
}
