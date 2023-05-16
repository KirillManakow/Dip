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

namespace Dip1
{
    /// <summary>
    /// Логика взаимодействия для Avt.xaml
    /// </summary>
    public partial class Avt : Page
    {
        public Frame frame1;
        public Avt(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            password1.Visibility = Visibility.Collapsed;
        }

        private void Enter(object sender, MouseButtonEventArgs e)
        {
            
            if (login.Text == "1" && password.Password == "1" || password1.Text =="1")
            {
                frame1.Navigate(new TeacherP(frame1));
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль", "Ошибка авторизации");
            }
        }
        private void glas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            password.Visibility = Visibility.Hidden;
            password1.Visibility = Visibility.Visible;
            glas.Visibility = Visibility.Hidden;
            glas_show.Visibility = Visibility.Visible;
            password1.Text = password.Password;
        }

        private void glas_show_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            password.Visibility = Visibility.Visible;
            password1.Visibility = Visibility.Hidden;
            glas.Visibility = Visibility.Visible;
            glas_show.Visibility = Visibility.Hidden;
            password.Password = password1.Text;
        }
    }
}
