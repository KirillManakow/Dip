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
    /// Логика взаимодействия для AddPractice.xaml
    /// </summary>
    public partial class AddPractice : Page
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public Frame frame1;
        public AddPractice(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;

         
        }

        private void Insert(object sender, MouseButtonEventArgs e)
        {
            
            string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
           string cmd = "Insert into sotrydniki.praktiki (ID_Prepod,ID_Tip_Prakt,GroupP,Kvalificaciya,Specialnost,Data_Nach,Date_Okon) values (@ln,@mn,@ad,@co,@ca,@cc,@cs)";
            MySqlCommand ins = new MySqlCommand(cmd, (MySqlConnection)con);
            ins.Parameters.AddWithValue("@ln", Fam.Text);
            ins.Parameters.AddWithValue("@mn", Prac.Text);
            ins.Parameters.AddWithValue("@ad", Grou.Text);
            ins.Parameters.AddWithValue("@co", Kval.Text);
            ins.Parameters.AddWithValue("@ca", Spec.Text);
            ins.Parameters.AddWithValue("@cc", DataN.Text);
            ins.Parameters.AddWithValue("@cs", DataK.Text);
            
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
            frame1.Navigate(new AttestationsP(frame1));
        }

        private void Back(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new Practice(frame1));
        }
    }
}
