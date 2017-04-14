namespace PracticeCoreCDPs.Areas.Factory.Core
{
    public class ChartProviderFree : IChartProvider
    {
        public IChart GetChart() //Acts a Factory Method
        {
            IChart chart = new BarChart();
            return chart;
        }
    }
}
