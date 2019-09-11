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

        //test newTest = new test();
        //fmeContent.Content = newTest;

        public Dashboard()
        {
            InitializeComponent();
            stpNav.Height = this.Height;
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeForm newAddEmployeeForm = new AddEmployeeForm();
            this.Content = newAddEmployeeForm;
        }

        private void btnEditEmployee_Click(object sender, RoutedEventArgs e)
        {
            EditEmployeeForm newEditEmployeeForm = new EditEmployeeForm();
            this.Content = newEditEmployeeForm;
        }

        private void btnViewAll_Click(object sender, RoutedEventArgs e)
        {
            ViewAllEmployeesForm newViewAllEmployeesForm = new ViewAllEmployeesForm();
            this.Content = newViewAllEmployeesForm;
        }
    }
}
