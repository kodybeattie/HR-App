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
using System.Data.SqlClient;

namespace HRApp
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        /// <summary>
        /// Initialization
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection cnn;
            cnn = new SqlConnection(Globals.CONNECTION_STRING);
            cnn.Open();

            SqlDataReader reader;
            string sql, Output = "";
            sql = "SELECT Username, Password FROM Employee WHERE Username = @Username and Password = @Password";

            SqlCommand command = new SqlCommand(sql, cnn);
            SqlParameter username = new SqlParameter();
            SqlParameter password = new SqlParameter();

            username.ParameterName = "@Username";
            username.Value = txtUsername.Text;
            command.Parameters.Add(username);

            password.ParameterName = "@Password";
            password.Value = txtPassword.Text;
            command.Parameters.Add(password);

            reader = command.ExecuteReader();
            if (reader.Read())
            {
                //MessageBox.Show(reader.GetValue(0).ToString());
                Dashboard newDash = new Dashboard();
                newDash.Show();
                this.Close();
            }
            else
            {
                lblError.Content = "No User Found";
            }
            cnn.Close();

        }
    }
}
