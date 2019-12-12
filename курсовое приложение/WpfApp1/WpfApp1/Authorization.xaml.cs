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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private model.kursovikEntities entity = new model.kursovikEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = lgtb.Text;
            string pass = pstb.Password;
            var user = entity.Users.FirstOrDefault(x => x.Login == login && x.Pass == pass);
            if (user != null)
            {
                MenuWindow mw = new MenuWindow(user);
                mw.Closed += (asd, dsa) => Show();
                Hide();
                mw.Show();
            }
            else
            {
                MessageBox.Show("Не правильно введен логин или пароль.");
            }
        }
    }
}
