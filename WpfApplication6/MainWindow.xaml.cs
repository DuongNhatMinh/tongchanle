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

namespace WpfApplication6
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

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, RoutedEventArgs e)
        {
            int nhap = Convert.ToInt32(txtNhapSo.Text);
            int tongday = 0;
            int tongchan = 0;
            int tongle = 0;
            if (rbnTong.IsChecked == true)
            {
                for (int i = 0; i <= nhap; i++)
                {
                    tongday = tongday + i;
                }
                txtKetQua.Text = tongday.ToString();
            }
            if (rbnTongChan.IsChecked == true)
            {
                for (int i = 0; i <= nhap; i++)
                    if (i % 2 == 0)
                    {
                        tongchan += i;
                        txtKetQua.Text = tongchan.ToString();
                    }
            }
            if (rbnTongLe.IsChecked == true)
            {
                for (int i = 0; i <= nhap; i++)
                    if (i % 2 != 0)
                    {
                        tongle += i;
                        txtKetQua.Text = tongle.ToString();
                    }
            }
        }
    }
}

