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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        DmitriiEntities context;
        public Page1()
        {
            InitializeComponent();
            context = new DmitriiEntities();

        }

        private void EnterClick1(object sender, RoutedEventArgs e)
        {
            int tabNum1 = Convert.ToInt32(Login1.Text);
            string FIO = FIO1.Text;
            int Position = Convert.ToInt32(position1.Text);
            DateTime Data =Convert.ToDateTime(Data1.Text);

            if (context.Employer.Any(x => x.tabNum == tabNum1))
            {
                Employer tabNum = context.Employer.ToList().Find(x => x.tabNum == tabNum1);
                if (tabNum == null)
                {
                    MessageBox.Show("Работника с таким логином не существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);

                }

                else
                {
                    Employer name = context.Employer.ToList().Find(x => x.name == FIO);
                    if (name == null)
                    {
                        MessageBox.Show("Работника с таким ФИО не существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        Employer position = context.Employer.ToList().Find(x => x.position == Position);
                        if (position == null)
                        {
                            MessageBox.Show("Работника с такой должностью не существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            Employer dateStartWork = context.Employer.ToList().Find(x => x.dateStartWork == Data);
                            if (dateStartWork == null)
                            {
                                MessageBox.Show("Работника с такой датой трудоустройства не существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            else
                            {
                                MessageBox.Show($"Ваш пароль {tabNum.password}");
                            }
                        }
                    }

                }
            }
        }
    }
}