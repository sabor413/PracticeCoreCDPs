using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using PracticeCoreCDPs.Areas.Factory.Core;

namespace PracticeCoreCDPs.Areas.Factory.Controllers
{
    [Area("Factory")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GetImageFree();
            GetImagePaid();
            return View();
        }

        public void GetImageFree()
        {
            ChartProviderFree cp = new ChartProviderFree();
            IChart chart = cp.GetChart();

            chart.Title = "Hours per day";

            List<string> xdata = new List<string>();
            xdata.Add("Mon");
            xdata.Add("Tue");
            xdata.Add("Wed");
            xdata.Add("Thu");
            xdata.Add("Fri");
            xdata.Add("Sat");
            xdata.Add("Sun");

            List<int> ydata = new List<int>();
            ydata.Add(12);
            ydata.Add(7);
            ydata.Add(4);
            ydata.Add(10);
            ydata.Add(3);
            ydata.Add(11);
            ydata.Add(5);

            List<Color> colordata= new List<Color>();
            colordata.Add(Color.Red);
            colordata.Add(Color.Blue);
            colordata.Add(Color.Yellow);
            colordata.Add(Color.Orange);
            colordata.Add(Color.Green);
            colordata.Add(Color.DarkGoldenrod);
            colordata.Add(Color.MediumOrchid);

            chart.XData = xdata;
            chart.YData = ydata;
            chart.ColorData = colordata;
            Bitmap bmp = chart.GenerateChart();
            string path = Path.Combine(Environment.CurrentDirectory, "wwwroot\\images\\home\\getimagefree.png");
            bmp.Save(path, ImageFormat.Png);
        }

        public void GetImagePaid()
        {
            ChartProviderPaid cp = new ChartProviderPaid();
            IChart chart = cp.GetChart();

            chart.Title = "Hours per day";

            List<string> xdata = new List<string>();
            xdata.Add("Mon");
            xdata.Add("Tue");
            xdata.Add("Wed");
            xdata.Add("Thu");
            xdata.Add("Fri");
            xdata.Add("Sat");
            xdata.Add("Sun");

            List<int> ydata = new List<int>();
            ydata.Add(12);
            ydata.Add(7);
            ydata.Add(4);
            ydata.Add(10);
            ydata.Add(3);
            ydata.Add(11);
            ydata.Add(5);

            List<Color> colordata = new List<Color>();
            colordata.Add(Color.Red);
            colordata.Add(Color.Blue);
            colordata.Add(Color.Yellow);
            colordata.Add(Color.Orange);
            colordata.Add(Color.Green);
            colordata.Add(Color.DarkGoldenrod);
            colordata.Add(Color.MediumOrchid);

            chart.XData = xdata;
            chart.YData = ydata;
            chart.ColorData = colordata;
            Bitmap bmp = chart.GenerateChart();
            string path = Path.Combine(Environment.CurrentDirectory, "wwwroot\\images\\home\\getimagepaid.png");
            bmp.Save(path, ImageFormat.Png);
        }
    }
}
