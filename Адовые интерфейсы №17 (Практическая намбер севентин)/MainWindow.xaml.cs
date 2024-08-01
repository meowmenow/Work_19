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

namespace Адовые_интерфейсы__17__Практическая_намбер_севентин_
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zn1.Clear();
            zn2.Clear();
            rez.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int x1, x2, z;
            x1 = Convert.ToInt32(zn1.Text);
            x2 = Convert.ToInt32(zn2.Text);
            z = x1 + x2;
            rez.Text = Convert.ToString(z);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
