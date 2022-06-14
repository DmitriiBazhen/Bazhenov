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

namespace Bazhenov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DmitriiEntities context;
        public MainWindow()
        {
            InitializeComponent();
            context = new DmitriiEntities();
            Button1.IsEnabled = false;

        }
        int a = 0;
        private void EnterClick(object sender, RoutedEventArgs e)
        {
            int tabNum = Convert.ToInt32(Login.Text);
            string pass = Password.Text;

            Employer worker = context.Employer.ToList().Find(x => x.tabNum == tabNum);
            if (worker == null)
            {
                MessageBox.Show("Работника с таким логином не существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                a = a + 1;
                if (a >= 3)
                {
                    Button.IsEnabled = false;
                    Login.IsEnabled = false;
                    Password.IsEnabled = false;
                    Button1.IsEnabled = true;
                }
            }

            else
            {
                if (worker.password.Equals(pass))
                {
                    MessageBox.Show("Успешная авторизация!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    a++;
                    if (a >= 3)
                    {
                        Button.IsEnabled = false;
                        Login.IsEnabled = false;
                        Password.IsEnabled = false;
                        Button1.IsEnabled = true;
                    }
                }
            }

        }

        private void EnterClick2(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page1();
        }
    }
}
