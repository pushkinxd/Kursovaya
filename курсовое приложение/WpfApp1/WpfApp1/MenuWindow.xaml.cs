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

// ПРАВКА ДЛЯ КОММИТА ЛОЛ КЕК ЧЕБУРЕК

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        private model.Users curent_user;
        public MenuWindow(model.Users user)
        {
            InitializeComponent();
            curent_user = user;
        }
    }
}
