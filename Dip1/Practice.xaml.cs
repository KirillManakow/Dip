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
    /// Логика взаимодействия для Practice.xaml
    /// </summary>
    public partial class Practice : Page
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public Frame frame1;
        public Practice(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            try
            {

                string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
                MySqlConnection con = new MySqlConnection(connectstring);
                cmd = new MySqlCommand("SELECT ID_Prakt as 'ID', prepod_sostav.Familiya as 'Фамилия', " +
                    "tipi_praktiki.Tip_Parkt 'Тип практики' , " +
                    "praktiki.GroupP as 'Группа', " +
                    "Kvalificaciya as 'Квалификация'," +
                    "Specialnost as 'Специальность'," +
                    "Data_Nach as 'Дата начала'," +
                    "Date_Okon as 'Дата окончания' " +
                    "From praktiki,prepod_sostav,tipi_praktiki " +
                    "Where praktiki.ID_Prepod = prepod_sostav.ID_Prepod and tipi_praktiki.ID_Tip_Prakt = praktiki.ID_Tip_Prakt", con);

                con.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                con.Close();               

                List<string[]> praktikis = dt.Select().Select(dr => dr.ItemArray.Select(x => x.ToString()).ToArray()).ToList();
                LViewTours.ItemsSource = praktikis;

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }      
        }
        private async void clicl_del(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(100);
            if (MessageBox.Show("Вы хотите удалить эту запись?",
                    "Удаление файла",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                object del = LViewTours.SelectedItem;
                string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
                MySqlConnection con = new MySqlConnection(connectstring);
                DataTable dt = new DataTable();
                List<string[]> praktikis = dt.Select().Select(dr => dr.ItemArray.Select(x => x.ToString()).ToArray()).ToList();
                cmd = new MySqlCommand("DELETE Fromt praktiki Where ID_Prakt 'prakitki[0]'");
                LViewTours.ItemsSource = praktikis;
                frame1.Navigate(new Practice(frame1));

            }
        }
        private void Update()
        {
            //string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
            //MySqlConnection con = new MySqlConnection(connectstring);
            //cmd = new MySqlCommand("SELECT ID_Prakt as 'ID', prepod_sostav.Familiya as 'Фамилия', " +
            //    "tipi_praktiki.Tip_Parkt 'Тип практики' , " +
            //    "praktiki.GroupP as 'Группа', " +
            //    "Kvalificaciya as 'Квалификация'," +
            //    "Specialnost as 'Специальность'," +
            //    "Data_Nach as 'Дата начала'," +
            //    "Date_Okon as 'Дата окончания' " +
            //    "From praktiki,prepod_sostav,tipi_praktiki " +
            //    "Where praktiki.ID_Prepod = prepod_sostav.ID_Prepod and tipi_praktiki.ID_Tip_Prakt = praktiki.ID_Tip_Prakt", con);

            //con.Open();
            //DataTable dt = new DataTable();
            //dt.Load(cmd.ExecuteReader());
            //con.Close();
            //List<string[]> praktikis = dt.Select().Select(dr => dr.ItemArray.Select(x => x.ToString()).ToArray()).ToList();
            //var sr = praktikis.ToList();

            //sr = sr.Where(p => p.GroupBy.GroupP.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            //LViewTours.ItemsSource = sr.ToList();
        }



        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
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

        private void TeacherE(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new TeacherP(frame1));
        }

        private void AddPractice(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new AddPractice(frame1));
        }

    }

    public class GrouPP
    {
        public string GroupP;
        public GrouPP(string GroupP)
        {
            this.GroupP = GroupP;
        }
    }
}
