using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chartssample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Chart();
        }

        private void Load_Chart()
        {

            List<User> users = Get_Users();

            ChartValues<double> values = new ChartValues<double>();
            List<String> lables = new List<string>();
            foreach (var item in users)
            {
                values.Add(item.AGE);
                lables.Add(item.NAME);
            }

            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Age",
                    Values = values,
                    DataLabels = true,
                    Fill = System.Windows.Media.Brushes.Green
                }
            };


            //x axis labels
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Users",
                Labels = lables,
                Unit = 1
            });


            //y axis label
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Age",
                LabelFormatter = value => value.ToString()

            });

        }

        private List<User> Get_Users()
        {
            List<User> list = new List<User>();
            list.Add(new User { NAME = "Jay", LOGIN = "jmaesas", AGE = 25, DOB = "02/20/2018", SCORE = 98 });
            list.Add(new User { NAME = "John", LOGIN = "jmaesas", AGE = 45, DOB = "02/20/2018", SCORE = 100 });
            list.Add(new User { NAME = "Bryan", LOGIN = "jmaesas", AGE = 22, DOB = "02/20/2018", SCORE = 50 });
            list.Add(new User { NAME = "Luke", LOGIN = "jmaesas", AGE = 29, DOB = "02/20/2018", SCORE = 30 });
            list.Add(new User { NAME = "James", LOGIN = "jmaesas", AGE = 31, DOB = "02/20/2018", SCORE = 60 });
            list.Add(new User { NAME = "Eric", LOGIN = "jmaesas", AGE = 23, DOB = "02/20/2018", SCORE = 40 });
            list.Add(new User { NAME = "Daniel", LOGIN = "jmaesas", AGE = 27, DOB = "02/20/2018", SCORE = 98 });
            list.Add(new User { NAME = "Andre", LOGIN = "jmaesas", AGE = 28, DOB = "02/20/2018", SCORE = 90 });


            return list;
        }

    }


    public class User
    {
        public String NAME { get; set; }
        public String LOGIN { get; set; }
        public int AGE { get; set; }
        public String DOB { get; set; }
        public int SCORE { get; set; }

    }
   
}




