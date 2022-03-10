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
using LibForDemoSchool;

namespace DemoSchoolMarkshev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        List<string> StudMassFio = new List<string>();
        List<int> StudMassYear = new List<int>();
        List<int> StudMassGroup = new List<int>();

        public void Fill_Button_Click(object sender, RoutedEventArgs e)
        {

            Students st0 = new Students();
            st0.fio = "Тимошин Василий Игнатьевич";
            StudMassFio.Add(st0.fio);
            st0.year = 2000;
            StudMassYear.Add(st0.year);
            st0.group = 01;
            StudMassGroup.Add(st0.group);
            
            Students st1 = new Students();
            st1.fio = "Колесов Ануфрий Парфеньевич";
            StudMassFio.Add(st1.fio);
            st1.year = 2000;
            StudMassYear.Add(st1.year);
            st1.group = 01;
            StudMassGroup.Add(st1.group);

            Students st2 = new Students();
            st2.fio = "Титов Ярополк Иванович";
            StudMassFio.Add(st2.fio);
            st2.year = 2000;
            StudMassYear.Add(st2.year);
            st2.group = 01;
            StudMassGroup.Add(st2.group);

            Students st3 = new Students();
            st3.fio = "Луговой Сергей Робертович";
            StudMassFio.Add(st3.fio);
            st3.year = 2001;
            StudMassYear.Add(st3.year);
            st3.group = 02;
            StudMassGroup.Add(st3.group);

            Students st4 = new Students();
            st4.fio = "Красильникова Жанна Борисовна";
            StudMassFio.Add(st4.fio);
            st4.year = 2001;
            StudMassYear.Add(st4.year);
            st4.group = 02;
            StudMassGroup.Add(st4.group);


        }

        private void GenMark_Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> Mark = new List<string> { "2", "3", "4", "5" };
            //Mark GetMarks(DateTime now, List<string> Students);
        }

        private void MinAVG_Button_Click(object sender, RoutedEventArgs e)
        {
            //double MinAVG(string[] marks);
        }

        private void Truancy_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Disease_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StudNumber_Button_Click(object sender, RoutedEventArgs e)
        {
            GetStudNumbers gsn = new GetStudNumbers();
            
            string number = gsn.StudNumber(StudMassFio[0], StudMassYear[0], StudMassGroup[0]);
        }
    }
}
