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
    /// Логика взаимодействия для TeachersInfo.xaml
    /// </summary>
    public partial class TeachersInfo : Page
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public Frame frame1;
        object Item;
        object ItemO;
        public TeachersInfo(Frame frame, object item, object itemo)
        {
            InitializeComponent();
            frame1 = frame;
            Item = item;
            First(item);
        }

        public void First(object item)
        {
            string connectstring = "server=localhost;uid=root;pwd=12357;database=sotrydniki";
            MySqlConnection con = new MySqlConnection(connectstring);
            cmd = new MySqlCommand("SELECT Photo,Familiya, Imya,Otchestvo,Data_Rozhd,Staj_Raboti,Staj_Raboti_Po_Spec FROM sotrydniki.prepod_sostav", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();

            List<string[]> praktikis = dt.Select().Select(dr => dr.ItemArray.Select(x => x.ToString()).ToArray()).ToList();
            object itemm = item;
            string[] t = (string[])item;
            Famil.Text = t[2];
            Imya.Text = t[3];
            Otch.Text = t[4];
            Rozd.Text = t[5];
            Staz.Text = t[6];
            StazSpec.Text = t[7];
            con.Close();
        }

    }
    
}
