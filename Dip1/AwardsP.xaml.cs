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
    /// Логика взаимодействия для AwardsP.xaml
    /// </summary>
    public partial class AwardsP : Page
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public Frame frame1;
        public AwardsP(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            try
            {

                string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
                MySqlConnection con = new MySqlConnection(connectstring);
                cmd = new MySqlCommand("SELECT prepod_sostav.Familiya, Date_Vrych, Opsianije FROM nagradi, prepod_sostav where nagradi.ID_Prepod = prepod_sostav.ID_Prepod", con);


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

        private void InternshipsE(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new InternshipsP(frame1));
        }

        private void TeacherE(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new TeacherP(frame1));
        }

        private void AddAwards(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new AddAwards(frame1));
        }
    }
}
