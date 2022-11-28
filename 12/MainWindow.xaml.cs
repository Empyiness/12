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
using System.Windows.Threading;

namespace _12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += TimerTick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            TimeBox.Text = DateTime.Now.ToString("HH:mm");
            DateBox.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }
        private void CalculateTask1(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(X1Box.Text, out int x1) || !int.TryParse(X2Box.Text, out int x2) ||
                !int.TryParse(Y1Box.Text, out int y1) || !int.TryParse(Y2Box.Text, out int y2))
            {
                MessageBox.Show("Invalid data!");
                return;
            }
            Task1ResultBox.Text = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)).ToString();
            X1Box.Focus();
        }
        private void CalculateTask2(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(NumberBox.Text, out int number) || NumberBox.Text.Length != 3)
            {
                MessageBox.Show("Invalid data!");
                return;
            }
            Task2ResultBox.Text = (number / 100).ToString();
            NumberBox.Focus();
        }
        private void DataChangedTask1(object sender, TextChangedEventArgs e)
        {
            Task1ResultBox.Clear();
        }
        private void DataChangedTask2(object sender, TextChangedEventArgs e)
        {
            Task2ResultBox.Clear();
        }
        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("• Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2,y2) на плоскости.\r\n• Дано трехзначное число. Используя одну операцию деления нацело, вывести первую цифру данного числа (сотни).");
        }
        private void Help(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Help is on the way, please wait!");
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
