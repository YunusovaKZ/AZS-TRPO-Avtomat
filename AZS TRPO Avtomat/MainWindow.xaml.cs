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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AZS_TRPO_Avtomat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String LabelText { get; set; }
        int n, a;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            tbAzs.Text = tbAzs.Text + 1;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            tbAzs.Text = tbAzs.Text + 2;
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            tbAzs.Text = tbAzs.Text + 3;
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            tbAzs.Text = tbAzs.Text + 4;
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            tbAzs.Text = tbAzs.Text + 5;
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            tbAzs.Text = tbAzs.Text + 6;
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            tbAzs.Text = tbAzs.Text + 7;
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            tbAzs.Text = tbAzs.Text + 8;
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            tbAzs.Text = tbAzs.Text + 9;
        }
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            tbAzs.Text = tbAzs.Text + 0;
        }
        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            int lenght = tbAzs.Text.Length - 1;
            string text = tbAzs.Text;
            tbAzs.Clear();
            for (int i = 0; i < lenght; i++)
            {
                tbAzs.Text = tbAzs.Text + text[i];
            }
        }

        private void btn92_Click(object sender, RoutedEventArgs e)
        {
            n = 0;
            n = n + Convert.ToInt32(tbAzs.Text);
            if(n>100)
            {
                tbAzs.Text = "Извините! В бензоколонке не хватает бензина! Уменьшите литры.";
            }
            else
            {
                n = n * 46;
                tbAzs.Text = Convert.ToString(n);
                return;
            }
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            Kard k = new Kard();
            k.Show();
            this.Close();
        }

        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(LabelText);
            n = n - a;
            if(n>0)
            {
                tbAzs.Text="На балансе недостаточно средств! Повторите оплату другой картой!";
                return;
            }
            else
            {
                tbAzs.Text="Оплата прошла успешно!";
                return;
            }
        }
    }
}
