using Microsoft.VisualBasic.ApplicationServices;
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

namespace Exam_Alekseev.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        User contexntUser;
        public RegPage()
        {
            InitializeComponent();
            CBRole.ItemsSource = App.db.Role.ToList();
            contexntUser = new User();
            DataContext = contexntUser;

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BReg_Click(object sender, RoutedEventArgs e)
        {
            App.db.Users.Add(contexntUser);
            App.db.SaveChanges();
            NavigationService.GoBack();
        }
    }
}
