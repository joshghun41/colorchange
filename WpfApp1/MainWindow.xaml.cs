using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfApp1
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

        private void box1Btn_Click(object sender, RoutedEventArgs e)
        {
           
            if (sender is Button btn)
            {
                btn.Background = PickBrush();
            }
        }
        private Brush PickBrush()
        {
            Brush result = Brushes.Transparent;

            Random rnd = new Random();

            Type brushesType = typeof(Brushes);

            PropertyInfo[] properties = brushesType.GetProperties();

            int random = rnd.Next(properties.Length);
            result = (Brush)properties[random].GetValue(null, null);

            return result;
        }

        private void box1Btn_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                this.Title=btn.Content.ToString();
                int btn_contect =int.Parse(btn.Content.ToString());

                if(btn_contect >= 1 && btn_contect <= 3)
                {
                    mypanel1.Children.Remove(btn);
                }
                if (btn_contect >= 3 && btn_contect <= 6)
                {
                    mypanel2.Children.Remove(btn);
                }
            }
        }
    }
}
