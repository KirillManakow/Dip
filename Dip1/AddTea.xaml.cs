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
    /// Логика взаимодействия для AddTea.xaml
    /// </summary>
    public partial class AddTea : Page
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public Frame frame1;
        public AddTea(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
        }
        private void Insert(object sender, MouseButtonEventArgs e)
        {

            string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string cmd = "Insert into sotrydniki.prepod_sostav (Familiya,Imya,Otchestvo,Data_Rozhd,Photo,Staj_Raboti,Staj_Raboti_Po_Spec)" +
                " values (@ln,@mn,@pp,@lp,@ph,@mp,@ll)";
            MySqlCommand ins = new MySqlCommand(cmd, (MySqlConnection)con);
            ins.Parameters.AddWithValue("@ln", Fam.Text);
            ins.Parameters.AddWithValue("@mn", Imya.Text);
            ins.Parameters.AddWithValue("@pp", Otch.Text);
            ins.Parameters.AddWithValue("@lp", Rozd.Text);
            ins.Parameters.AddWithValue("@ph", Photo.Text);    
            ins.Parameters.AddWithValue("@mp", Staz.Text);
            ins.Parameters.AddWithValue("@ll", Staz_Spec.Text);



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
            frame1.Navigate(new TeacherP(frame1));
        }

        private void Back(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new Practice(frame1));
        }
    }
}
