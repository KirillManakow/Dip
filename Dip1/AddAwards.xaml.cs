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
    /// Логика взаимодействия для AddAwards.xaml
    /// </summary>
    public partial class AddAwards : Page
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public Frame frame1;
        public AddAwards(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
        }
        private void Insert(object sender, MouseButtonEventArgs e)
        {

            string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string cmd = "Insert into sotrydniki.nagradi (ID_Prepod,Date_Vrych,Opsianije) values (@pr,@ln,@mn)";
            MySqlCommand ins = new MySqlCommand(cmd, (MySqlConnection)con);
            ins.Parameters.AddWithValue("@pr", Fam.Text);
            ins.Parameters.AddWithValue("@ln", DataV.Text);
            ins.Parameters.AddWithValue("@mn", Descr.Text);


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
            frame1.Navigate(new AwardsP(frame1));
        }

        private void Back(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new AwardsP(frame1));
        }
    }
}
