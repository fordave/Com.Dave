using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using LiveCharts.Geared;

namespace WpfWebDemo.ViewModels
{
    class MultipleSeriesViewModel
    {
        public MultipleSeriesViewModel()
        {
            Series = new SeriesCollection();
            var r = new Random();

            var count = 1;
            var length = 1;
            for (var i = 0; i < count; i++) // 30 series
            {
                var trend = 0d;
                var values = new double[length];

                for (var j = 0; j < length; j++) // 10k points each
                {
                    trend += (r.NextDouble() < .8 ? 1 : -1) * r.Next(0, 10);
                    values[j] = trend;
                }

                var series = new LineSeries
                {
                    Values = values.AsGearedValues().WithQuality(Quality.Highest),
                    Fill = Brushes.Transparent,
                    StrokeThickness = .5,
                    PointGeometry = null //use a null geometry when you have many series
                };
                Series.Add(series);
            }
        }

        public SeriesCollection Series { get; set; }
    }
}
