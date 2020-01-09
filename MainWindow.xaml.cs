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

namespace ChiaDuLuyThuaNoiChuoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnKT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnTinh_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)RadioThuong.IsChecked)
                Radiothuong();
            else
                if ((bool)RadioDu.IsChecked)
                    Radiodu();
                else
                    if ((bool)RadioLT.IsChecked)
                        RadioLt();
                    else
                        if ((bool)RadioNC.IsChecked)
                            RadioNc();
        }

        private void Radiothuong()
        {
            double GT1= Double.Parse(txt1.Text);
            double GT2 = Double.Parse(txt2.Text);
            double outcome = 0;

            if (GT2 == 0)
                MessageBox.Show("Lỗi");
            else
            {
                outcome = GT1 / GT2;
                KQ.Text = outcome.ToString();
            }
        }

        private void Radiodu()
        {
            double GT1 = Double.Parse(txt1.Text);
            double GT2 = Double.Parse(txt2.Text);
            double outcome = 0;

            if (GT2 == 0)
                MessageBox.Show("Lỗi");
            else
            {
                outcome = GT1 % GT2;
                KQ.Text = outcome.ToString();
            }
        }

        private void RadioLt()
        {
            double GT1 = Double.Parse(txt1.Text);
            double GT2 = Double.Parse(txt2.Text);
            double outcome = 1;

            for (int i = 1; i <= GT2; i++)
                outcome *= GT1;

           KQ.Text = outcome.ToString();
        }

        private void RadioNc()
        {
            KQ.Text = txt1.Text + txt2.Text;
        }
    }
}