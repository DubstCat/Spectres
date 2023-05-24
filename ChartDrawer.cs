using System.Collections.Generic;
using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace Spectres
{
    public static class ChartDrawer
    {
        public static void drawChart(Chart chart, Func<double, int, List<FunctionPoint>> method, double[] M, int N)
        {
            int index = 0;

            foreach (double currentM in M)
            {
                List<FunctionPoint> grafik = method.Invoke(currentM, N);

                foreach (FunctionPoint point in grafik)
                {
                    chart.Series[index].Points.AddXY(point.y, point.x);
                }
                index++;
            }
        }
    }
}
