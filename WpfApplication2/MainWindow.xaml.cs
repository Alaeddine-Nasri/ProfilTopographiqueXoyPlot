using System;
using System.Collections.Generic;
using System.Linq;
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


namespace WpfApplication2
{
    using System.Collections.Generic;

    using OxyPlot;

    public class MainViewModel
    {
        public MainViewModel()
        {


            this.Title = "Example 2";
           // int cpt = 0;
            double a = 40, b = 12;

            //for (cpt = 0; cpt < 10; cpt++)
           // {
                this.Points = new List<DataPoint>
            
                              {
                                  new DataPoint(20, 30),
                                  new DataPoint(10, 20),
                                  new DataPoint(a, b),

                              };
            


          //  }

        }
        
        
        public string Title { get; private set; }

        public IList<DataPoint> Points { get; private set; }
    }
}
