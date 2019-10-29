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
using System.Windows.Shapes;

namespace HRApp
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void mnuAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            dkpContent.Children.Clear();
            AddEmployeeForm newAddEmployeeForm = new AddEmployeeForm();
            dkpContent.Children.Add(newAddEmployeeForm);
        }
        
        private void mnuEditEmployee_Click(object sender, RoutedEventArgs e)
        {
            dkpContent.Children.Clear();
            EditEmployeeForm newEditEmployeeForm = new EditEmployeeForm();
            dkpContent.Children.Add(newEditEmployeeForm);
        }

        private void mnuViewAllEmployees_Click(object sender, RoutedEventArgs e)
        {
            dkpContent.Children.Clear();
            ViewAllEmployeesForm newViewAllEmployeesForm = new ViewAllEmployeesForm();
            dkpContent.Children.Add(newViewAllEmployeesForm);
        }
    }
}
