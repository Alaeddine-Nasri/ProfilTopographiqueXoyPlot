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
    using OxyPlot.Wpf;

    public class MainViewModel
    {
        public MainViewModel()
        {


            this.Title = "Profil Topographique";
            int cpt = 0;// Pour parcourir la list des intersections
            int point1 = 1; //Pour cree la liste
            double x , y ;
          //  for ()                                     // parcour liste


         //   {                                          // debut de parcour

                x = 40; // afectation des x avec echele
                y = 12; // affectation des altitudes 
            


            /*************************************First Point + creation ***********************************/
            if (point1 == 1) { 
            Points = new List<DataPoint>
            {
                new DataPoint(x, y),
            };
                point1 = 2;
            }


            /************************************* The rest of the points ***********************************/
            for (cpt = 0; cpt < 10; cpt++)//Instead of 10 put the number of intersections -2;
            {
               
                Points.Add(new DataPoint(x, y));
 
            }

            //Suivant de x et y dans la liste .

           // }                                           //Fin parcour liste



        }
        
        
        public string Title { get; private set; }

        public IList<DataPoint> Points { get; private set; }
        public object Plot { get; }
    }
}
