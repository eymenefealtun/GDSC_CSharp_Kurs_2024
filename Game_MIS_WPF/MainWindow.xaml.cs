using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Game_MIS_WPF
{
    public partial class MainWindow : Window
    {
        List<Customer> _customerList = new List<Customer>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRemoveCustomer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dgwCustomers.ItemsSource = null;

                Customer customer = new Customer()
                {
                    Id = Convert.ToInt32(tBoxId.Text),
                    FirstName = tBoxFirstName.Text,
                    LastName = tBoxLastName.Text,
                    Gender = tBoxGender.Text
                };

                // LINQ
                //_customerList.Remove(customer); // bu satır calısmayacak cunku objeler hafızada parametreleri aynı aolsada farklı kodalama ile tutuluyor

                Customer customerToBeDeleted = _customerList.FirstOrDefault(x => x.Id == customer.Id);
                _customerList.Remove(customerToBeDeleted);


                dgwCustomers.ItemsSource = _customerList;

                // CLEAR BOXES
                ClearBoxes();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                dgwCustomers.ItemsSource = _customerList;
                ClearBoxes();
            }
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dgwCustomers.ItemsSource = null;

                Customer customer = new Customer()
                {
                    Id = Convert.ToInt32(tBoxId.Text),
                    FirstName = tBoxFirstName.Text,
                    LastName = tBoxLastName.Text,
                    Gender = tBoxGender.Text
                };

                _customerList.Add(customer);

                dgwCustomers.ItemsSource = _customerList;

                // CLEAR BOXES
                ClearBoxes();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                dgwCustomers.ItemsSource = _customerList;
                ClearBoxes();
            }


        }

        private void ClearBoxes()
        {
            tBoxFirstName.Text = "";
            tBoxLastName.Text = "";
            tBoxId.Text = "";
            tBoxGender.Text = "";
        }

        private void dgwCustomers_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                Customer customer = ((DataGrid)sender).SelectedItem as Customer;

                tBoxFirstName.Text = customer.FirstName;
                tBoxLastName.Text = customer.LastName;
                tBoxId.Text = customer.Id.ToString();
                tBoxGender.Text = customer.Gender;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


    }
}
