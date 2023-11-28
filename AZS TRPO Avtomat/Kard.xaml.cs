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
using System.Windows.Shapes;

namespace AZS_TRPO_Avtomat
{
    /// <summary>
    /// Логика взаимодействия для Kard.xaml
    /// </summary>
    public partial class Kard : Window
    {
        public Kard()
        {
            InitializeComponent();
        }

        private void Dark_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.LabelText = tbDark.Text;
            m.Show();
            this.Close();
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.LabelText = tbRed.Text;
            m.Show();
            this.Close();
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.LabelText = tbBlue.Text;
            m.Show();
            this.Close();
        }
    }
}
