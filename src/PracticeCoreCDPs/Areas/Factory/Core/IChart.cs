using System.Collections.Generic;
using System.Drawing;

namespace PracticeCoreCDPs.Areas.Factory.Core
{
    public interface IChart
    {
        string Title { get; set; }
        List<string> XData { get; set; }
        List<int> YData { get; set; }
        List<Color> ColorData { get; set; }
        Bitmap GenerateChart();
    }
}
