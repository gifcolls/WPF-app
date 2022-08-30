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

namespace _301215601_GiselleF_Lab_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            loadInfo.Click += LoadInfo;
            clearInfo.Click += ClearInfo;
        }

        public void LoadInfo(object sender, EventArgs e)
        {
            string inputnameOfItem = nameOfItem.Text;
            string inputquantity = quantity.Text;
            string inpuprice = price.Text;
            string inputFfirstName = firstName.Text;
            string inputLastName = lastName.Text;
            string inputDOB = dayOfBirth.Text;
            string inputCustomerNu = CustomerNumber.Text;
            string inputItemId = ItemId.Text;
            string inpuShipCost = shipCost.Text;

            if (!string.IsNullOrWhiteSpace(inputFfirstName) || string.IsNullOrWhiteSpace(inputLastName)
                || string.IsNullOrWhiteSpace(inputDOB) || string.IsNullOrWhiteSpace(inputCustomerNu)
                || string.IsNullOrWhiteSpace(inputItemId) || string.IsNullOrWhiteSpace(inpuShipCost))
            {
                MessageBox.Show("Please complete all the information", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {

                MessageBox.Show($"{inputLastName}, {inputFfirstName}\n {inputDOB}\n{inputCustomerNu}");
            }
    }

        private void ClearInfo(object sender, EventArgs e)
        {
            nameOfItem.Clear();
            quantity.Clear();
            price.Clear();
            firstName.Clear();
            lastName.Clear();
            dayOfBirth.Clear();
            CustomerNumber.Clear();
            ItemId.Clear();
            shipCost.Clear();
        }


    }
}
