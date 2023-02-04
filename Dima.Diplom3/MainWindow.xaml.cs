using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dima.Diplom3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //-------------------------------------------------------TEST1
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "val1",
                    Values = new ChartValues<double> {5, 1, 15, 20}
                }
            };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "val2",
                Values = new ChartValues<double> { 10, 15, 20, 25 }
            });

            BarLabels = new[] { "value1", "value2", "value3", "value4" };
            Formatter = value => value.ToString("N");

            //-------------------------------------------------------TEST2
            SeriesCollection2 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "t1",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(10) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "t2",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(20) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "t3",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(27) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "t3",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(33) },
                    DataLabels = true
                },
            };

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] BarLabels { get; set; }
        public Func<double, string> Formatter { get; set; }


        //-------------------------------------------------------TEST2
        public SeriesCollection SeriesCollection2 { get; set; }

        private void PieChart_DataClick(object sender, ChartPoint chartPoint)
        {
            MessageBox.Show("Current value: " + chartPoint.Y + "(" + (chartPoint.Participation * 100).ToString() + " %)");
        }
    }
}
