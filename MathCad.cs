using System;
using System.Collections.Generic;

namespace Spectres
{
    public class MathCad {
        private int A = 2;
        private int K = 8;
        private double tau = 2e-6;
        private double F;
        private int[] M = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private List<double> f;
        private double T1;
        private List<double> t;
        private List<double> f0;
        private double T;
        private int N = 0;


        public MathCad()
        {
            F = K / tau;
            f = new List<double>();

            for (double fValue = -F; fValue <= F; fValue += 0.001 * F)
            {
                f.Add(fValue);
            }



            f0 = new List<double>();
            foreach (int element in M)
            {
                f0.Add(element / (4 * tau));
            }

            T = 5 * tau;
        }

        // U1 из раздела 1
        public List<FunctionPoint> razdel1U1(int MParam)
        {
            T1 = tau;

            t = new List<double>();

            for (double tValue = -T1; tValue <= T1; tValue += 0.001 * T1)
            {
                t.Add(tValue);
            }

            List<FunctionPoint> result = new List<FunctionPoint>();

            foreach(double tElement in t)
            {
                result.Add(new FunctionPoint(U1(tElement, MParam), tElement)); // Здесь М = 1 потому что хрен знает что делать с М
            }

            return result;
        }

        private double U1(double tParam, int MParam)
        { 
            if (tParam < -tau / 2 || tParam > tau / 2)
            {
                return 0;
            }
            double result = A * Math.Cos(2 * Math.PI * MParam * (tParam/(4*tau)));
            return result;
        }

        // C1 из раздела 1

        private double C1(double fParam, int MParam)
        {

            if (fParam != 0 && fParam != MParam/(4*tau) && fParam!= -MParam/(4*tau))
            {
                double part1 = A * (Math.Sin(Math.PI * tau * (fParam + (MParam / (4 * tau)))) / (2 * Math.PI * (fParam + (MParam / (4 * tau)))));
                double part2 = A * (Math.Sin(Math.PI * tau * (fParam - (MParam / (4 * tau)))) / (2 * Math.PI * (fParam - (MParam / (4 * tau)))));

                return part1 + part2;
            }

            if(fParam == 0 || MParam == 0)
            {
                return A * tau;
            }

            if (MParam!=0 && (fParam == MParam/(4 * tau) || fParam == -MParam/(4 * tau))) 
            {
                return A * (tau / 2) + A * tau * (Math.Sin(Math.PI * (MParam / 2)) / (Math.PI * MParam));
            }

            return 0;
        }

        private double S1(double fParam, int MParam) {
            return C1(fParam, MParam);
        }


        public List<FunctionPoint> razdel1E1(int MParam)
        {
            T1 = tau;

            t = new List<double>();

            for (double tValue = -T1; tValue <= T1; tValue += 0.001 * T1)
            {
                t.Add(tValue);
            }

            List<FunctionPoint> result = new List<FunctionPoint>();

            foreach (double fElement in f)
            {
                result.Add(new FunctionPoint(E1(fElement, MParam), fElement));
            }
            return result;
        }


        private double E1(double fParam, int MParam)
        {
            return Math.Abs(S1(fParam, MParam));
        }

        private double O1(double fParam, int MParam)
        {
            return 0;
        }

        //////////////////////////////////////////
        // Сюда вставить ещё одну функцию из 1 раздела
        //////////////////////////////////////////
        ///

        public List<FunctionPoint> razdel2U2(int MParam)
        {
            T1 = (N + 1) * T;

            t = new List<double>();

            for (double tValue = -T1; tValue <= T1; tValue += 0.001 * T1)
            {
                t.Add(tValue);
            }

            List<FunctionPoint> result = new List<FunctionPoint>();
            foreach (double tElement in t)
            {
                result.Add(new FunctionPoint(U2(tElement, MParam), tElement));
            }
            return result;
        }

        private double U2(double tParam, int MParam)
        {
            double summ = 0;
            for (int n = -N; n <= N; n++)
            {
                summ += U1(tParam - n * T, MParam);
            }
            return summ;
        }
       
    }
}
