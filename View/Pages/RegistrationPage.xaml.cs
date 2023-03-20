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
using Task_6_SQLite.Core;
using Task_6_SQLite.Model;

namespace Task_6_SQLite.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {

        private ModelContext? _db = null;
        private User _user = new User();
        public RegistrationPage()
        {
            InitializeComponent();

            _db = new ModelContext();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new LoginPage());
        }

        private void BntCreat_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbLogin.Text) ||
                string.IsNullOrEmpty(PbPassword.Password))
            {
                MessageBox.Show("Ошибка ввода данных",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    _user.Login = TbLogin.Text;
                    _user.Password= PbPassword.Password;
                    _user.RoleID = 2;

                    MessageBox.Show("Аккаунт пользователя успешно создан",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);

                    _db?.Users.Add( _user );
                    _db?.SaveChanges();

                    Util.UtilFrame?.Navigate(new LoginPage());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(),
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }
        }
    }
}
