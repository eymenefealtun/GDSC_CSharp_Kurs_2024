using _13_My_Bank_WPF.API;
using System.Windows;

namespace _13_My_Bank_WPF
{
    public partial class MainWindow : Window
    {
        CustomerApiManager _customerApiManager;
        public MainWindow()
        {
            InitializeComponent();
            _customerApiManager = new CustomerApiManager();
        }

        private async void btnGetCustomers_Click(object sender, RoutedEventArgs e)
        {
            var customers = await _customerApiManager.GetAllCustomers();

            dgwCustomers.ItemsSource = customers;

        }
    }
}
