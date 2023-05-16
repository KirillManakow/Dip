using MySql.Data.MySqlClient;
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
    /// Логика взаимодействия для AddInternship.xaml
    /// </summary>
    public partial class AddInternship : Page
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public Frame frame1;
        public AddInternship(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
        }
        private void Insert(object sender, MouseButtonEventArgs e)
        {

            string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string cmd = "Insert into sotrydniki.stagirovki (ID_Prepod,Organize,Data_Nach,Data_Okon) values (@pr,@ln,@mn,@ad)";
            MySqlCommand ins = new MySqlCommand(cmd, (MySqlConnection)con);
            ins.Parameters.AddWithValue("@pr", Fam.Text);
            ins.Parameters.AddWithValue("@ln", Org.Text);
            ins.Parameters.AddWithValue("@mn", DataN.Text);
            ins.Parameters.AddWithValue("@ad", DataO.Text);


            try
            {
                ins.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            MessageBox.Show("Данные успешно добавлены");
            frame1.Navigate(new InternshipsP(frame1));
        }

        private void Back(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new InternshipsP(frame1));
        }
    }
}
