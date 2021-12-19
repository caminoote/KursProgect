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

using System.Data.SqlClient;
using System.Data;

using DAL;
using BLL;
using BLL.Interfaces;

namespace KursProgect
{
    /// <summary>
    /// Логика взаимодействия для LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {

        private StorageContext db = new StorageContext();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
           if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string pass = txtPassword.Password.Trim();
            User authUser = null;

            if (login.Length < 3)
            {
                txtLogin.ToolTip = "";
                txtLogin.Background = Brushes.Red;
            }
            else if (pass.Length < 3)
            {
                txtPassword.ToolTip = "";
                txtPassword.Background = Brushes.Red;
            }
            else {
                authUser = db.User.Where(b => b.Login == login && b.Password == pass).FirstOrDefault();
            }

            if (authUser != null)
            { 
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
