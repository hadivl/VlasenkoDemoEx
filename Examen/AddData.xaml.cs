using Microsoft.Data.SqlClient;
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
using System.Windows.Shapes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Examen.Model;

namespace Examen
{
    /// <summary>
    /// Логика взаимодействия для AddData.xaml
    /// </summary>
    public partial class AddData : Window
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow()
            {
                Owner = this
            };

            this.Hide();
            mainWindow.ShowDialog();
            this.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            Client newClient = new Client
            {

                Familiya = FamilyaTextBox.Text,
                Imya = ImyaTextBox.Text,
                Otchestvo = OtcgestvoTextBox.Text,

            };

            string connectionString = "Data Source=hqvla3302s01\\KITP;Initial Catalog=Vlasenko_DemoEx;Integrated Security=True;Trust Server Certificate=True";
            string query = @"
    INSERT INTO Client (Familiya, Imya, Otchestvo) 
    VALUES (@Familiya, @Imya, @Otchestvo)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Familiya", newClient.Familiya);
                command.Parameters.AddWithValue("@Imya", newClient.Imya);
                command.Parameters.AddWithValue("@Otchestvo", newClient.Otchestvo);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новый клиент добавлен успешно.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении клиента: " + ex.Message);
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}