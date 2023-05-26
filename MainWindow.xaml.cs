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

namespace zadanie5
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

    

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            int x = Convert.ToInt32(textBoxA.Text);
            int y = Convert.ToInt32(textBoxA.Text);

            if ((x > -15 && x < 0 && y > -15 && y < 0) ||
(x > 0 && y > 0) || (x < -15 && y > 0) ||
(x < -15 && y < -15) || (x > 0 && y < -15))
            {
                        ResultLabel.Content = "ДА";
                    }
            else if (x < -1 || x > 1 || y < 0 || y > 2)
                ResultLabel.Content = "НЕТ";
                 else
                    ResultLabel.Content = "НА ГРАНИЦЕ";
                }

            }
           
        }
    

