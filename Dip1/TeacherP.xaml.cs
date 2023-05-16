using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для TeacherP.xaml
    /// </summary>
    public partial class TeacherP : Page
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public Frame frame1;    
        public TeacherP(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            try
            {

                string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
                MySqlConnection con = new MySqlConnection(connectstring);
                cmd = new MySqlCommand("SELECT ID_Prepod,Photo,Familiya, Imya,Otchestvo,Data_Rozhd,Staj_Raboti,Staj_Raboti_Po_Spec FROM sotrydniki.prepod_sostav", con);


                con.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                con.Close();

                List<string[]> praktikis = dt.Select().Select(dr => dr.ItemArray.Select(x => x.ToString()).ToArray()).ToList();
                LViewTours.ItemsSource = praktikis;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            try
            {

                string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
                MySqlConnection con = new MySqlConnection(connectstring);
                cmd = new MySqlCommand(" SELECT prepod_sostav.Familiya, Mesto_Obuch,Data_Okon, specialnosti.Specialnost, kvalificacii.Kvalificaciya FROM obrazovanie,prepod_sostav, specialnosti, kvalificacii where obrazovanie.ID_Prepod = prepod_sostav.ID_Prepod AND obrazovanie.ID_Specialnost = specialnosti.ID_Specialnost and obrazovanie.ID_Kvalificaciya = kvalificacii.ID_Kvalificaciya", con);
                con.Open();
                DataTable dt1 = new DataTable();
                dt1.Load(cmd.ExecuteReader());
                con.Close();

                List<string[]> obr = dt1.Select().Select(dr => dr.ItemArray.Select(x => x.ToString()).ToArray()).ToList();
                Obr.ItemsSource = obr;

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

           
        }
        private void EnterPractice(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new Practice(frame1));
        }

        private void AttestationsE(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new AttestationsP(frame1));
        }

        private void InternshipsE(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new InternshipsP(frame1));
        }

        private void AwardsE(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new AwardsP(frame1));
        }

        private async void TeachersIn(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(100);
            object item = LViewTours.SelectedItem;
            await Task.Delay(100);
            object itemo = Obr.SelectedItem;
            frame1.Navigate(new TeachersInfo(frame1,item,itemo));
        }

        private void AddTea(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new AddTea(frame1));
        }
    }
}
