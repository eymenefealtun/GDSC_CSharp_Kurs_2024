using System.Windows;

namespace _11_MyFirstWpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("button works");

            string givenText = tBoxInput.Text;
            MessageBox.Show($"You have written {givenText}");
        }


    }
}
