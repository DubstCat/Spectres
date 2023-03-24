using System.Collections.Generic;
using System;

namespace Spectres
{
    public static class ChartDrawer
    {
        public static void drawChart(System.Windows.Forms.DataVisualization.Charting.Chart chart, Func<int, List<FunctionPoint>> method, int[] M)
        {
            int index = 0;

            foreach (int currentM in M)
            {
                List<FunctionPoint> grafik = method.Invoke(currentM);

                foreach (FunctionPoint point in grafik)
                {
                    chart.Series[index].Points.AddXY(point.y, point.x);
                }
                index++;
            }
        }
    }
}
