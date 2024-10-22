using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void toonList_Click(object sender, RoutedEventArgs e)
        {
            int adadDorost;
            bool adad = int.TryParse(hoogsteGetal.Text, out adadDorost);
            if (adad)
            {
                while (adadDorost > 0)
                {
                    result.Text = adadDorost.ToString();
                    adadDorost--;

                }
            }

        }

        private void wissen_Click(object sender, RoutedEventArgs e)
        {
            hoogsteGetal.Clear();
            result.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}