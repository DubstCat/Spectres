using System;
using System.Collections.Generic;
using System.Numerics;

namespace Spectres
{
    public class MathCad {
        private int A = 2;
        private int K = 8;
        public double tau = 2e-6;
        private double F;
        private int[] M = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private List<double> f;
        private double T1;
        private List<double> t;
        private List<double> f0;
        private double T;
        // private int N = 0;


        public MathCad()
        {
            F = K / tau;
            f = new List<double>();

            for (double fValue = -F; fValue <= F; fValue += 0.0001 * F)
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

        // Раздел 1

        public List<FunctionPoint> razdel1U1(int MParam, int N)
        {
            T1 = tau;

            reinitializeT();

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


        public List<FunctionPoint> razdel1E1(int MParam, int NParam)
        {
            T1 = tau;

            reinitializeT();

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

        public List<FunctionPoint> razdel1O1(int MParam, int NParam)
        {
            List<FunctionPoint> result = new List<FunctionPoint>();

            foreach (double fElement in f)
            {
                result.Add(new FunctionPoint(O1(fElement, MParam), fElement));
            }
            return result;
        }

        private double O1(double fParam, int MParam)
        {
            if(S1(fParam, MParam) < 0) 
            {
                return Math.PI;
            }
            return 0;
        }

        // 2 раздел

        public List<FunctionPoint> razdel2U2(int MParam, int NParam)
        {
            T1 = (NParam + 1) * T;

            reinitializeT();

            List<FunctionPoint> result = new List<FunctionPoint>();
            foreach (double tElement in t)
            {
                result.Add(new FunctionPoint(U2(tElement, MParam, NParam), tElement));
            }
            return result;
        }

        private double U2(double tParam, int MParam, int NParam)
        {
            double summ = 0;
            for (int n = -NParam; n <= NParam; n++)
            {
                summ += U1(tParam - n * T, MParam);
            }
            return summ;
        }

        private double S2(double fParam, int MParam, int NParam)
        {
            double summ = 0;
            for (int n = -NParam; n <= NParam; n++)
            {
                summ += S1(fParam, MParam) * Math.Pow(0.99, (2 * fParam * n * T));
            }
            return summ;
        }

        public List<FunctionPoint> razdel2E2(int MParam, int NParam)
        {
            List<FunctionPoint> result = new List<FunctionPoint>();
            foreach (double fElement in f)
            {
                result.Add(new FunctionPoint(E2(fElement, MParam, NParam), fElement));
            }
            return result;
        }

        public double E2(double fParam, int MParam, int NParam)
        {
            return Math.Abs(S2(fParam, MParam, NParam));
        }

        public List<FunctionPoint> razdel2O2(int MParam, int NParam)
        {
            List<FunctionPoint> result = new List<FunctionPoint>();

            foreach (double fElement in f)
            {
                result.Add(new FunctionPoint(O2(fElement, MParam, NParam), fElement));
            }
            return result;
        }

        private double O2(double fParam, int MParam, int NParam)
        {
            if (S2(fParam, MParam, NParam) < 0)
            {
                return Math.PI;
            }
            return 0;
        }

        void reinitializeT()
        {
            t = new List<double>();

            for (double tValue = -T1; tValue <= T1; tValue += 0.001 * T1)
            {
                t.Add(tValue);
            }
        }
    }
}
