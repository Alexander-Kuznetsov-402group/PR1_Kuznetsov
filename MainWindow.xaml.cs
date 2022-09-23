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

namespace PR1_Kuznetsov
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
        private static readonly Random random = new Random();
        private void button1_click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Canvas.SetLeft(button2, random.Next(150, 300));
            Canvas.SetLeft(button3, random.Next(150, 300));
            Canvas.SetLeft(button4, random.Next(150, 300));
            Canvas.SetLeft(button5, random.Next(150, 300));
            Canvas.SetTop(button2, random.Next(100, 250));
            Canvas.SetTop(button3, random.Next(100, 250));
            Canvas.SetTop(button4, random.Next(100, 250));
            Canvas.SetTop(button5, random.Next(100, 250));
            button2.Width -= 3;
            button2.Height -= 3;
            button3.Width -= 3;
            button3.Height -= 3;
            button4.Width -= 3;
            button4.Height -= 3;
            button5.Width -= 3;
            button5.Height -= 3;
        }
    }
}
