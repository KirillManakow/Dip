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
    /// Логика взаимодействия для AddAttestations.xaml
    /// </summary>
    public partial class AddAttestations : Page
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public Frame frame1;
        public AddAttestations(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
       
        }

        private void Back(object sender, MouseButtonEventArgs e)
        {
            frame1.Navigate(new AttestationsP(frame1));
        }

        private void Insert(object sender, MouseButtonEventArgs e)
        {
            string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
            MySqlConnection con = new MySqlConnection(connectstring);
            con.Open();
            string cmd = "Insert into sotrydniki.attestacii_ped (ID_Prepod,ID_Tip_Attest, Data_Sdach, Result) values (@ln,@mn,@ad,@co)";
            MySqlCommand ins = new MySqlCommand(cmd, (MySqlConnection)con);
            ins.Parameters.AddWithValue("@ln", Fam.Text);
            ins.Parameters.AddWithValue("@mn", Att.Text);
            ins.Parameters.AddWithValue("@ad", Data.Text);
            ins.Parameters.AddWithValue("@co", Rez.Text);
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
    }
}
