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

namespace WpfCalculette
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double dblNb1;
            double dblNb2;
            double dblResponse;

            dblNb1 = Convert.ToInt32(tbxNumber1.Text);
            dblNb2 = Convert.ToInt32(tbxNumber2.Text);

            dblResponse = dblNb1 + dblNb2;
            lblResponse.Content = dblResponse.ToString();
        }
    }
}
