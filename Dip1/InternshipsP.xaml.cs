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
    /// Логика взаимодействия для InternshipsP.xaml
    /// </summary>
    public partial class InternshipsP : Page
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public Frame frame1;
        public InternshipsP(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            try
            {

                string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
                MySqlConnection con = new MySqlConnection(connectstring);
                cmd = new MySqlCommand("SELECT prepod_sostav.Familiya,Organize,Data_Nach,Data_Okon FROM stagirovki,prepod_sostav where stagirovki.ID_Prepod= prepod_sostav.ID_Prepod order by Familiya ", con);


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

        private void EnterPractice(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new Practice(frame1));
        }

        private void AttestationsE(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new AttestationsP(frame1));
        }

        private void AwardsE(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new AwardsP(frame1));
        }

        private void TeacherE(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new TeacherP(frame1));
        }

        private void AddInt(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new AddInternship(frame1));
        }
    }
}
