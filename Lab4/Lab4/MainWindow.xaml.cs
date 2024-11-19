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

namespace Lab4
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
            this.dollar2rubles.Text = (decimal.Parse(this.dollar_rate.Text) * decimal.Parse(this.dollar_sum.Text)).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.euro2rubles.Text = (decimal.Parse(this.euro_rate.Text) * decimal.Parse(this.euro_sum.Text)).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.grivn2rubles.Text = (decimal.Parse(this.grivn_rate.Text) * decimal.Parse(this.grivn_sum.Text)).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.dram2rubles.Text = (decimal.Parse(this.dram_rate.Text) * decimal.Parse(this.dram_sum.Text)).ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.duyms2meters.Text = (decimal.Parse(this.duym.Text) / (decimal)39.37).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.futs2meters.Text = (decimal.Parse(this.fut.Text) / (decimal)0.3048).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.miles2meters.Text = (decimal.Parse(this.mile.Text) * (decimal)1609.34).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.versts2meters.Text = (decimal.Parse(this.verst.Text) * (decimal)1066.8).ToString();
        }
    }
}
