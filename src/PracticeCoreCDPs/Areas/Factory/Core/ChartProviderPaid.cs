namespace PracticeCoreCDPs.Areas.Factory.Core
{
    public class ChartProviderPaid : IChartProvider
    {
        public IChart GetChart() //Acts a Factory Method
        {
            IChart chart = new PieChart();
            return chart;
        }
    }
}
